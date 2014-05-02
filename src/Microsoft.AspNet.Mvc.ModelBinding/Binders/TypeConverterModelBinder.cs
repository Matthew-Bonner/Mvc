// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING
// WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF
// TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR
// NON-INFRINGEMENT.
// See the Apache 2 License for the specific language governing
// permissions and limitations under the License.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.ModelBinding.Internal;

namespace Microsoft.AspNet.Mvc.ModelBinding
{
    public sealed class TypeConverterModelBinder : IModelBinder
    {
        public async Task<bool> BindModelAsync(ModelBindingContext bindingContext)
        {
            ModelBindingHelper.ValidateBindingContext(bindingContext);

            if (!ValueProviderResult.CanConvertFromString(bindingContext.ModelType))
            {
                // this type cannot be converted
                return false;
            }

            var valueProviderResult = await bindingContext.ValueProvider.GetValueAsync(bindingContext.ModelName);
            if (valueProviderResult == null)
            {
                return false; // no entry
            }

            object newModel;
            bindingContext.ModelState.SetModelValue(bindingContext.ModelName, valueProviderResult);
            try
            {
                newModel = valueProviderResult.ConvertTo(bindingContext.ModelType);
                ModelBindingHelper.ReplaceEmptyStringWithNull(bindingContext.ModelMetadata, ref newModel);
                bindingContext.Model = newModel;
            }
            catch (Exception ex)
            {
                if (IsFormatException(ex))
                {
                    // there was a type conversion failure
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName, ex.Message);
                }
                else
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName, ex);
                }
            }

            return true;
        }

        private static bool IsFormatException(Exception ex)
        {
            for (; ex != null; ex = ex.InnerException)
            {
                if (ex is FormatException)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

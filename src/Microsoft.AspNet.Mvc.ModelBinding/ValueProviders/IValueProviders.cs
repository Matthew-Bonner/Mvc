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

using System.Threading.Tasks;

namespace Microsoft.AspNet.Mvc.ModelBinding
{
    /// <summary>
    /// Defines the methods that are required for a value provider.
    /// </summary>
    public interface IValueProvider
    {
        /// <summary>
        /// Determines whether the collection contains the specified prefix.
        /// </summary>
        /// <param name="prefix">The prefix to search for.</param>
        /// <returns>true if the collection contains the specified prefix; otherwise, false.</returns>
        Task<bool> ContainsPrefixAsync(string prefix);

        /// <summary>
        /// Retrieves a value object using the specified key.
        /// </summary>
        /// <param name="key">The key of the value object to retrieve.</param>
        /// <returns>The value object for the specified key. If the exact key is not found, null.</returns>
        Task<ValueProviderResult> GetValueAsync(string key);
    }
}

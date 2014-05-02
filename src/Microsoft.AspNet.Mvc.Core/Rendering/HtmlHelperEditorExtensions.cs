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
using System.Linq.Expressions;

namespace Microsoft.AspNet.Mvc.Rendering
{
    public static class EditorExtensions
    {
        public static HtmlString Editor(this IHtmlHelper html, string expression)
        {
            return html.Editor(expression, templateName: null, htmlFieldName: null, additionalViewData: null);
        }

        public static HtmlString Editor(this IHtmlHelper html, string expression, object additionalViewData)
        {
            return html.Editor(expression, templateName: null, htmlFieldName: null,
                additionalViewData: additionalViewData);
        }

        public static HtmlString Editor(this IHtmlHelper html, string expression, string templateName)
        {
            return html.Editor(expression, templateName, htmlFieldName: null, additionalViewData: null);
        }

        public static HtmlString Editor(this IHtmlHelper html, string expression, string templateName,
            object additionalViewData)
        {
            return html.Editor(expression, templateName, htmlFieldName: null, additionalViewData: additionalViewData);
        }

        public static HtmlString Editor(this IHtmlHelper html, string expression, string templateName,
            string htmlFieldName)
        {
            return html.Editor(expression, templateName, htmlFieldName, additionalViewData: null);
        }

        public static HtmlString EditorFor<TModel, TValue>(this IHtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression)
        {
            return html.EditorFor(expression, templateName: null, htmlFieldName: null, additionalViewData: null);
        }

        public static HtmlString EditorFor<TModel, TValue>(this IHtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression, object additionalViewData)
        {
            return html.EditorFor(expression, templateName: null, htmlFieldName: null,
                additionalViewData: additionalViewData);
        }

        public static HtmlString EditorFor<TModel, TValue>(this IHtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression, string templateName)
        {
            return html.EditorFor(expression, templateName, htmlFieldName: null, additionalViewData: null);
        }

        public static HtmlString EditorFor<TModel, TValue>(this IHtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression, string templateName, object additionalViewData)
        {
            return html.EditorFor(expression, templateName, htmlFieldName: null,
                additionalViewData: additionalViewData);
        }

        public static HtmlString EditorFor<TModel, TValue>(this IHtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName)
        {
            return html.EditorFor(expression, templateName, htmlFieldName, additionalViewData: null);
        }

        public static HtmlString EditorForModel(this IHtmlHelper html)
        {
            return html.Editor(expression: string.Empty, templateName: null, htmlFieldName: null,
                additionalViewData: null);
        }

        public static HtmlString EditorForModel(this IHtmlHelper html, object additionalViewData)
        {
            return html.Editor(expression: string.Empty, templateName: null, htmlFieldName: null,
                additionalViewData: additionalViewData);
        }

        public static HtmlString EditorForModel(this IHtmlHelper html, string templateName)
        {
            return html.Editor(expression: string.Empty, templateName: templateName, htmlFieldName: null,
                additionalViewData: null);
        }

        public static HtmlString EditorForModel(this IHtmlHelper html, string templateName, object additionalViewData)
        {
            return html.Editor(expression: string.Empty, templateName: templateName, htmlFieldName: null,
                additionalViewData: additionalViewData);
        }

        public static HtmlString EditorForModel(this IHtmlHelper html, string templateName, string htmlFieldName)
        {
            return html.Editor(expression: string.Empty, templateName: templateName, htmlFieldName: htmlFieldName,
                additionalViewData: null);
        }

        public static HtmlString EditorForModel(this IHtmlHelper html, string templateName, string htmlFieldName,
            object additionalViewData)
        {
            return html.Editor(expression: string.Empty, templateName: templateName, htmlFieldName: htmlFieldName,
                additionalViewData: additionalViewData);
        }
    }
}

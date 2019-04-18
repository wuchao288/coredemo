// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcMovie.TagHelpers
{
    /// <summary>
    /// <see cref="ITagHelper"/> implementation targeting &lt;input&gt; elements with an <c>asp-for</c> attribute.
    /// </summary>
    [HtmlTargetElement("easyuivalidatebox", Attributes = ForAttributeName, TagStructure = TagStructure.WithoutEndTag)]
    public class EInputTagHelper : TagHelper
    {
        private const string ForAttributeName = "asp-for";
        private const string FormatAttributeName = "asp-format";

        // Mapping from datatype names and data annotation hints to values for the <input/> element's "type" attribute.
        private static readonly Dictionary<string, string> _defaultInputTypes =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "HiddenInput", InputType.Hidden.ToString().ToLowerInvariant() },
                { "Password", InputType.Password.ToString().ToLowerInvariant() },
                { "Text", InputType.Text.ToString().ToLowerInvariant() },
                { "PhoneNumber", "tel" },
                { "Url", "url" },
                { "EmailAddress", "email" },
                { "Date", "date" },
                { "DateTime", "datetime-local" },
                { "DateTime-local", "datetime-local" },
                { nameof(DateTimeOffset), "text" },
                { "Time", "time" },
                { "Week", "week" },
                { "Month", "month" },
                { nameof(Byte), "number" },
                { nameof(SByte), "number" },
                { nameof(Int16), "number" },
                { nameof(UInt16), "number" },
                { nameof(Int32), "number" },
                { nameof(UInt32), "number" },
                { nameof(Int64), "number" },
                { nameof(UInt64), "number" },
                { nameof(Single), InputType.Text.ToString().ToLowerInvariant() },
                { nameof(Double), InputType.Text.ToString().ToLowerInvariant() },
                { nameof(Boolean), InputType.CheckBox.ToString().ToLowerInvariant() },
                { nameof(Decimal), InputType.Text.ToString().ToLowerInvariant() },
                { nameof(String), InputType.Text.ToString().ToLowerInvariant() },
                { nameof(IFormFile), "file" },
                { TemplateRenderer.IEnumerableOfIFormFileName, "file" },
            };

        // Mapping from <input/> element's type to RFC 3339 date and time formats.
      

        /// <summary>
        /// Creates a new <see cref="InputTagHelper"/>.
        /// </summary>
        /// <param name="generator">The <see cref="IHtmlGenerator"/>.</param>
        public EInputTagHelper(IHtmlGenerator generator)
        {
            Generator = generator;
        }

        /// <inheritdoc />
        public override int Order => -1000;

        /// <summary>
        /// Gets the <see cref="IHtmlGenerator"/> used to generate the <see cref="InputTagHelper"/>'s output.
        /// </summary>
        protected IHtmlGenerator Generator { get; }

        /// <summary>
        /// Gets the <see cref="Rendering.ViewContext"/> of the executing view.
        /// </summary>
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        /// <summary>
        /// An expression to be evaluated against the current model.
        /// </summary>
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        /// <summary>
        /// The format string (see https://msdn.microsoft.com/en-us/library/txafckwd.aspx) used to format the
        /// <see cref="For"/> result. Sets the generated "value" attribute to that formatted string.
        /// </summary>
        /// <remarks>
        /// Not used if the provided (see <see cref="InputTypeName"/>) or calculated "type" attribute value is
        /// <c>checkbox</c>, <c>password</c>, or <c>radio</c>. That is, <see cref="Format"/> is used when calling
        /// <see cref="IHtmlGenerator.GenerateTextBox"/>.
        /// </remarks>
        [HtmlAttributeName(FormatAttributeName)]
        public string Format { get; set; }

        /// <summary>
        /// The type of the &lt;input&gt; element.
        /// </summary>
        /// <remarks>
        /// Passed through to the generated HTML in all cases. Also used to determine the <see cref="IHtmlGenerator"/>
        /// helper to call and the default <see cref="Format"/> value. A default <see cref="Format"/> is not calculated
        /// if the provided (see <see cref="InputTypeName"/>) or calculated "type" attribute value is <c>checkbox</c>,
        /// <c>hidden</c>, <c>password</c>, or <c>radio</c>.
        /// </remarks>
        [HtmlAttributeName("type")]
        public string InputTypeName { get; set; } = "input";

        /// <summary>
        /// The name of the &lt;input&gt; element.
        /// </summary>
        /// <remarks>
        /// Passed through to the generated HTML in all cases. Also used to determine whether <see cref="For"/> is
        /// valid with an empty <see cref="ModelExpression.Name"/>.
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// The value of the &lt;input&gt; element.
        /// </summary>
        /// <remarks>
        /// Passed through to the generated HTML in all cases. Also used to determine the generated "checked" attribute
        /// if <see cref="InputTypeName"/> is "radio". Must not be <c>null</c> in that case.
        /// </remarks>
        public string Value { get; set; }

        /// <inheritdoc />
        /// <remarks>Does nothing if <see cref="For"/> is <c>null</c>.</remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if <see cref="Format"/> is non-<c>null</c> but <see cref="For"/> is <c>null</c>.
        /// </exception>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            // Pass through attributes that are also well-known HTML attributes. Must be done prior to any copying
            // from a TagBuilder.
            if (InputTypeName != null)
            {
                output.CopyHtmlAttribute("type", context);
            }

            if (Name != null)
            {
                output.CopyHtmlAttribute(nameof(Name), context);
            }

            if (Value != null)
            {
                output.CopyHtmlAttribute(nameof(Value), context);
            }

            // Note null or empty For.Name is allowed because TemplateInfo.HtmlFieldPrefix may be sufficient.
            // IHtmlGenerator will enforce name requirements.
            var metadata = For.Metadata;
            var modelExplorer = For.ModelExplorer;
            if (metadata == null)
            {
                //throw new InvalidOperationException(Resources.FormatTagHelpers_NoProvidedMetadata(
                //    "<input>",
                //    ForAttributeName,
                //    nameof(IModelMetadataProvider),
                //    For.Name));
                throw new Exception();
            }

 


            // inputType may be more specific than default the generator chooses below.
            if (!output.Attributes.ContainsName("type"))
            {
                output.Attributes.SetAttribute("type", InputTypeName);
            }
           
            // Ensure Generator does not throw due to empty "fullName" if user provided a name attribute.
            IDictionary<string, object> htmlAttributes = null;
            if (string.IsNullOrEmpty(For.Name) &&
                string.IsNullOrEmpty(ViewContext.ViewData.TemplateInfo.HtmlFieldPrefix) &&
                !string.IsNullOrEmpty(Name))
            {
                htmlAttributes = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase)
                {
                    { "name", Name },
                };
            }

            TagBuilder tagBuilder = GenerateTextBox(modelExplorer, InputTypeName, htmlAttributes);

            tagBuilder.AddCssClass("");

            if (tagBuilder != null)
            {
                // This TagBuilder contains the one <input/> element of interest.
                output.MergeAttributes(tagBuilder);
                //处理属性
                if (tagBuilder.HasInnerHtml)
                {
                    // Since this is not the "checkbox" special-case, no guarantee that output is a self-closing
                    // element. A later tag helper targeting this element may change output.TagMode.
                    output.Content.AppendHtml(tagBuilder.InnerHtml);
                }
                output.TagName = "input";
                //output.Content.SetContent(output.Content.GetContent().Replace("einput", "input"));
            }
           
        }

        /// <summary>
        /// Gets an &lt;input&gt; element's "type" attribute value based on the given <paramref name="modelExplorer"/>
        /// or <see cref="InputType"/>.
        /// </summary>
        /// <param name="modelExplorer">The <see cref="ModelExplorer"/> to use.</param>
        /// <param name="inputTypeHint">When this method returns, contains the string, often the name of a
        /// <see cref="ModelMetadata.ModelType"/> base class, used to determine this method's return value.</param>
        /// <returns>An &lt;input&gt; element's "type" attribute value.</returns>
       
        private TagBuilder GenerateCheckBox(
            ModelExplorer modelExplorer,
            TagHelperOutput output,
            IDictionary<string, object> htmlAttributes)
        {
            if (modelExplorer.ModelType == typeof(string))
            {
                if (modelExplorer.Model != null)
                {
                    if (!bool.TryParse(modelExplorer.Model.ToString(), out var potentialBool))
                    {
                        //throw new InvalidOperationException(Resources.FormatInputTagHelper_InvalidStringResult(
                        //    ForAttributeName,
                        //    modelExplorer.Model.ToString(),
                        //    typeof(bool).FullName));
                        throw new Exception();
                    }
                }
            }
            else if (modelExplorer.ModelType != typeof(bool))
            {
                //throw new InvalidOperationException(Resources.FormatInputTagHelper_InvalidExpressionResult(
                //       "<input>",
                //       ForAttributeName,
                //       modelExplorer.ModelType.FullName,
                //       typeof(bool).FullName,
                //       typeof(string).FullName,
                //       "type",
                //       "checkbox"));
                throw new Exception();
            }

            // hiddenForCheckboxTag always rendered after the returned element
            var hiddenForCheckboxTag = Generator.GenerateHiddenForCheckbox(ViewContext, modelExplorer, For.Name);
            if (hiddenForCheckboxTag != null)
            {
                var renderingMode =
                    output.TagMode == TagMode.SelfClosing ? TagRenderMode.SelfClosing : TagRenderMode.StartTag;
                hiddenForCheckboxTag.TagRenderMode = renderingMode;
                if (!hiddenForCheckboxTag.Attributes.ContainsKey("name") &&
                    !string.IsNullOrEmpty(Name))
                {
                    // The checkbox and hidden elements should have the same name attribute value. Attributes will
                    // match if both are present because both have a generated value. Reach here in the special case
                    // where user provided a non-empty fallback name.
                    hiddenForCheckboxTag.MergeAttribute("name", Name);
                }

                if (ViewContext.FormContext.CanRenderAtEndOfForm)
                {
                    ViewContext.FormContext.EndOfFormContent.Add(hiddenForCheckboxTag);
                }
                else
                {
                    output.PostElement.AppendHtml(hiddenForCheckboxTag);
                }
            }

            return Generator.GenerateCheckBox(
                ViewContext,
                modelExplorer,
                For.Name,
                isChecked: null,
                htmlAttributes: htmlAttributes);
        }

        private TagBuilder GenerateRadio(ModelExplorer modelExplorer, IDictionary<string, object> htmlAttributes)
        {
            // Note empty string is allowed.
            if (Value == null)
            {
                //throw new InvalidOperationException(Resources.FormatInputTagHelper_ValueRequired(
                //    "<input>",
                //    nameof(Value).ToLowerInvariant(),
                //    "type",
                //    "radio"));
                throw new Exception();
            }

            return Generator.GenerateRadioButton(
                ViewContext,
                modelExplorer,
                For.Name,
                Value,
                isChecked: null,
                htmlAttributes: htmlAttributes);
        }

        private TagBuilder GenerateTextBox(
            ModelExplorer modelExplorer,
            string inputType,
            IDictionary<string, object> htmlAttributes)
        {
            var format = Format;
          

            if (htmlAttributes == null)
            {
                htmlAttributes = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            }

            htmlAttributes["type"] = inputType;
            

            return Generator.GenerateTextBox(
                ViewContext,
                modelExplorer,
                For.Name,
                modelExplorer.Model,
                format,
                htmlAttributes);
        }

        // Imitate Generator.GenerateHidden() using Generator.GenerateTextBox(). This adds support for asp-format that
        // is not available in Generator.GenerateHidden().
        private TagBuilder GenerateHidden(ModelExplorer modelExplorer, IDictionary<string, object> htmlAttributes)
        {
            var value = For.Model;
            if (value is byte[] byteArrayValue)
            {
                value = Convert.ToBase64String(byteArrayValue);
            }

            if (htmlAttributes == null)
            {
                htmlAttributes = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            }

            // In DefaultHtmlGenerator(), GenerateTextBox() calls GenerateInput() _almost_ identically to how
            // GenerateHidden() does and the main switch inside GenerateInput() handles InputType.Text and
            // InputType.Hidden identically. No behavior differences at all when a type HTML attribute already exists.
            htmlAttributes["type"] = "hidden";

            return Generator.GenerateTextBox(ViewContext, modelExplorer, For.Name, value, Format, htmlAttributes);
        }


        // A variant of TemplateRenderer.GetViewNames(). Main change relates to bool? handling.
     
    }
}

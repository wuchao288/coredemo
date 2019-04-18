using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcMovie.TagHelpers
{
    // You may need to install the Microsoft.AspNet.Razor.Runtime package into your project
    [HtmlTargetElement("field")]
    public class FieldTagHelper : TagHelper
    {
        protected IHtmlGenerator Generator { get; }

        [HtmlAttributeName("label")]
        public string Label { get; set; }

        [HtmlAttributeName("cols")]
        public int ColumnCount { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "form-group");

            var childContent = await output.GetChildContentAsync();

            output.Content.SetHtmlContent($@" 
<label class='col-md-{ColumnCount} control-label'>{Label}</label>
<div class='form-value col-md-{12 - ColumnCount}'>{childContent.GetContent()}</div>");
        }
    }
}
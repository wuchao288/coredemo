#pragma checksum "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2eecdac9e43afe7a506bce95a08180411ca2379f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login.cshtml", typeof(AspNetCore.Views_Login_Login))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eecdac9e43afe7a506bce95a08180411ca2379f", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e715c8594e7d63a339bad834cf6a8fd8201c6b96", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("请输入用户名"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-begin", new global::Microsoft.AspNetCore.Html.HtmlString("onBegin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString("onComplete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("onFailed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-loading", new global::Microsoft.AspNetCore.Html.HtmlString("#load"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "登录";

#line default
#line hidden
            BeginContext(71, 294, true);
            WriteLiteral(@"<style>
    /* ----- Validation and error messages class starts -----*/
    .input-validation-error {
        border-color: #dc3545;
    }

    /* -- --Validation and error messages class ends -- --*/
</style>
<div class=""row"">
    <div class=""col-xs-10 col-sm-8 col-md-6"">

        ");
            EndContext();
            BeginContext(365, 1357, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eecdac9e43afe7a506bce95a08180411ca2379f8721", async() => {
                BeginContext(657, 28, true);
                WriteLiteral("\r\n            <!--所有的错误-->\r\n");
                EndContext();
                BeginContext(763, 45, true);
                WriteLiteral("            <!---不包含属性上的错误---->\r\n            ");
                EndContext();
                BeginContext(808, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eecdac9e43afe7a506bce95a08180411ca2379f9290", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 25 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(874, 58, true);
                WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(932, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eecdac9e43afe7a506bce95a08180411ca2379f11135", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 28 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(966, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(984, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2eecdac9e43afe7a506bce95a08180411ca2379f12761", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 29 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1054, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1072, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eecdac9e43afe7a506bce95a08180411ca2379f14557", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 30 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1135, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(1211, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eecdac9e43afe7a506bce95a08180411ca2379f16406", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 33 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1245, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1263, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2eecdac9e43afe7a506bce95a08180411ca2379f18034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 34 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1312, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1330, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eecdac9e43afe7a506bce95a08180411ca2379f19743", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 35 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1393, 24, true);
                WriteLiteral("\r\n\r\n            </div>\r\n");
                EndContext();
                BeginContext(1634, 81, true);
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary\">登录</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("formnovalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1722, 50, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div id=\"Results\"></div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1790, 4844, true);
                WriteLiteral(@"

    <script>

        //创建简单遮罩层，显示load时的信息，配合Unobtrusive


        $(document).ready(function () {

            console.info($(""div[data-loadlayer=true]""));
        });

        var results = $(""#Results"");
        var onBegin = function () {
            results.html(""<img src=\""/images/ajax-loader.gif\"" alt=\""Loading\"" />"");
        };

        var onComplete = function () {
            //results.html("""");
        };

        var onSuccess = function (context) {
            alert(context);
        };

        var onFailed = function (context) {
            alert(""Failed"");
        };
    </script>
    <script>
        ; (function ($) {
            //设置背景层高
            function height() {
                var scrollHeight, offsetHeight;
                // handle IE 6
                if ($.browser.msie && $.browser.version < 7) {
                    scrollHeight = Math.max(document.documentElement.scrollHeight, document.body.scrollHeight);
                    offsetHeight ");
                WriteLiteral(@"= Math.max(document.documentElement.offsetHeight, document.body.offsetHeight);
                    if (scrollHeight < offsetHeight) {
                        return $(window).height();
                    } else {
                        return scrollHeight;
                    }
                    // handle ""good"" browsers
                }
                else if ($.browser.msie && $.browser.version == 8) {
                    return $(document).height() - 4;
                }
                else {
                    return $(document).height();
                }
            };
            //设置背景层宽
            function width() {
                var scrollWidth, offsetWidth;
                // handle IE
                if ($.browser.msie) {
                    scrollWidth = Math.max(document.documentElement.scrollWidth, document.body.scrollWidth);
                    offsetWidth = Math.max(document.documentElement.offsetWidth, document.body.offsetWidth);
                    if (scrol");
                WriteLiteral(@"lWidth < offsetWidth) {
                        return $(window).width();
                    } else {
                        return scrollWidth;
                    }
                    // handle ""good"" browsers
                }
                else {
                    return $(document).width();
                }
            };
            /*==========全部遮罩=========*/
            function createLayer(load) {
                //背景遮罩层
                var layer = $(""<div id="" + load.attr(""data-loadlayer-id"") + ""></div>"");
                layer.css({
                    zIndex: 9998,
                    position: ""absolute"",
                    height: height() + ""px"",
                    width: width() + ""px"",
                    background: ""black"",
                    top: 0,
                    left: 0,
                    filter: ""alpha(opacity=30)"",
                    opacity: 0.3
                });

                //图片及文字层
                var content = $(""<div id="" + loa");
                WriteLiteral(@"d.attr(""data-loadlayer-id"") + ""-content"" + ""></div>"");
                content.css({
                    textAlign: ""left"",
                    position: ""absolute"",
                    zIndex: 9999,
                    //height: opt.height + ""px"",
                    //width: opt.width + ""px"",
                    top: ""50%"",
                    left: ""50%"",
                    verticalAlign: ""middle"",
                    //background: opt.backgroudColor,""#ECECEC""
                    background: ""#ECECEC"",
                    borderRadius: ""3px"",
                    padding: ""2px 5px 2px 5px"",
                    fontSize: ""13px""
                });

                //content.append(""<img style='vertical-align:middle;margin:"" + (opt.height / 4) + ""px; 0 0 5px;margin-right:5px;' src='"" + opt.backgroundImage + ""' /><span style='text-align:center; vertical-align:middle;'>"" + opt.text + ""</span>"");
                content.append(""<span style='text-align:center; vertical-align:middle;color:#00000");
                WriteLiteral(@"0'>"" + load.attr(""data-loadlayer-msg"") + ""</span>"");
                load.append(layer.append(content));
                var top = content.css(""top"").replace('px', '');
                var left = content.css(""left"").replace('px', '');
                content.css(""top"", (parseFloat(top) - parseFloat(content.css(""height"")) / 2)).css(""left"", (parseFloat(left) - parseFloat(content.css(""width"")) / 2));
                console.info(""backgroudColor"");
                layer.hide();
                return this;
            }

            $(document).ready(function () {
                createLayer($(""div[data-loadlayer=true]""))
                console.info(""div[data-loadlayer=true]"");
            });
        })($)
    </script>
    ");
                EndContext();
                BeginContext(6635, 52, false);
#line 173 "D:\Users\Administrator\Source\Repos\coredemo\MvcMovie\Views\Login\Login.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(6687, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(6692, 461, true);
            WriteLiteral(@"<style>
    .loadEffect {
        width: 100px;
        height: 100px;
        position: relative;
        margin: 0 auto;
        margin-top: 100px;
    }

        .loadEffect span {
            display: inline-block;
            width: 16px;
            height: 16px;
            border-radius: 50%;
            background: lightgreen;
            position: absolute;
            -webkit-animation: load 1.04s ease infinite;
        }

    ");
            EndContext();
            BeginContext(7154, 1282, true);
            WriteLiteral(@"@-webkit-keyframes load {
        0% {
            opacity: 1;
        }

        100% {
            opacity: 0.2;
        }
    }

    .loadEffect span:nth-child(1) {
        left: 0;
        top: 50%;
        margin-top: -8px;
        -webkit-animation-delay: 0.13s;
    }

    .loadEffect span:nth-child(2) {
        left: 14px;
        top: 14px;
        -webkit-animation-delay: 0.26s;
    }

    .loadEffect span:nth-child(3) {
        left: 50%;
        top: 0;
        margin-left: -8px;
        -webkit-animation-delay: 0.39s;
    }

    .loadEffect span:nth-child(4) {
        top: 14px;
        right: 14px;
        -webkit-animation-delay: 0.52s;
    }

    .loadEffect span:nth-child(5) {
        right: 0;
        top: 50%;
        margin-top: -8px;
        -webkit-animation-delay: 0.65s;
    }

    .loadEffect span:nth-child(6) {
        right: 14px;
        bottom: 14px;
        -webkit-animation-delay: 0.78s;
    }

    .loadEffect span:nth-child(7) {
 ");
            WriteLiteral(@"       bottom: 0;
        left: 50%;
        margin-left: -8px;
        -webkit-animation-delay: 0.91s;
    }

    .loadEffect span:nth-child(8) {
        bottom: 14px;
        left: 14px;
        -webkit-animation-delay: 1.04s;
    }
</style>

");
            EndContext();
            BeginContext(8713, 1163, true);
            WriteLiteral(@"
<div data-loadlayer=""true"" data-loadlayer-id=""load"" data-loadlayer-msg=""loading...""></div>

<style>
    .datagrid-mask {
        background: #ccc;
    }

    .datagrid-mask-msg {
        border-color: #D3D3D3;
    }

    .datagrid-mask {
        position: absolute;
        left: 0;
        top: 0;
        width: 100%;
        height: 100%;
        opacity: 0.3;
        filter: alpha(opacity=30);
        display: none;
    }

    .datagrid-mask-msg {
        position: absolute;
        top: 50%;
        margin-top: -20px;
        padding: 10px 5px 10px 30px;
        width: auto;
        border-width: 2px;
        border-style: solid;
        display: none;
        background: #ffffff url('http://localhost:2323/Content/jquery-easyui-1.4.1/themes/gray/images/loading.gif') no-repeat scroll 5px center;
    }
</style>

<div id=""loading"" style=""display:none"">
    <div id=""loading1"" class=""datagrid-mask"" style=""display: block; width: 100%; height: 937px; z-index: 10000;""></div>
");
            WriteLiteral("    <div id=\"loading2\" class=\"datagrid-mask-msg\" style=\"display: block; left: 865px; top: 446px; z-index: 10000;\">正在处理，请稍候。。。</div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

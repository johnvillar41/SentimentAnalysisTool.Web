#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80215762b3c4606526940c5e4778e5be17bd25df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TextProcessing_Index), @"mvc.1.0.view", @"/Views/TextProcessing/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\_ViewImports.cshtml"
using SentimentAnalysisTool.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\_ViewImports.cshtml"
using SentimentAnalysisTool.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80215762b3c4606526940c5e4778e5be17bd25df", @"/Views/TextProcessing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_TextProcessing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SentimentAnalysisTool.Web.Models.TextProcessingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/textprocessing-index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card mb-2 shadow-sm"">
            <div class=""card-header"">
                Corpus Types
            </div>
            <div class=""card-body"">
                <div class=""d-flex"">
                    <div class=""mr-auto"">
                        <div class=""btn-group btn-group-toggle"" data-toggle=""buttons"">
");
#nullable restore
#line 13 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                             foreach (var item in Model.CorpusTypes)
                            {                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <label class=""btn btn-secondary"">
                                    <input type=""radio""
                                           autocomplete=""off""
                                           data-ajax=""true""
                                           data-ajax-update=""#corpus-data-panel""
                                           data-ajax-loading=""#spinner-upload""
                                           asp-controller=""TextProcessing""
                                           asp-action=""LoadCorpusTypeData""");
            BeginWriteAttribute("asp-route-corpusTypeId", "\r\n                                           asp-route-corpusTypeId=\"", 1143, "\"", 1230, 1);
#nullable restore
#line 23 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
WriteAttributeValue("", 1212, item.CorpusTypeId, 1212, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                                           value=\"", 1231, "\"", 1303, 1);
#nullable restore
#line 24 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
WriteAttributeValue("", 1283, item.CorpusTypeName, 1283, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />                                    \r\n                                    \r\n                                </label>\r\n");
#nullable restore
#line 27 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-12"">
        <div class=""card mb-2 shadow-sm"">
            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#slang"" role=""tab"" aria-selected=""true"">Slang Records</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#abbrevs"" role=""tab"" aria-selected=""false"">Abbreviations</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#corpus-words"" role=""tab"" aria-selected=""false"">Corpus</a>
                </li>
            </ul>
            <div id=""corpus-data-panel"">
                ");
#nullable restore
#line 50 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml"
           Write(await Html.PartialAsync("_CorpusDataPartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80215762b3c4606526940c5e4778e5be17bd25df7793", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SentimentAnalysisTool.Web.Models.TextProcessingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\TextProcessing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eea7091cc0af56cdbf73bb90937b56b3086aaf07"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eea7091cc0af56cdbf73bb90937b56b3086aaf07", @"/Views/TextProcessing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_TextProcessing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SentimentAnalysisTool.Web.Models.TextProcessingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
    <li class=""nav-item"">
        <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#slang"" role=""tab"" aria-selected=""true"">Slang Records</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#abbrevs"" role=""tab"" aria-selected=""false"">Abbreviations</a>
    </li>
</ul>
<div class=""tab-content mt-1"" id=""myTabContent"">
    <div class=""tab-pane fade show active"" id=""slang"" role=""tabpanel"" aria-labelledby=""home-tab"">
        <button type=""button"" class=""btn btn-dark mb-1"">Add Slang words <i class=""fas fa-plus-circle""></i></button>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">First</th>
                    <th scope=""col"">Last</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">1</th>
            ");
            WriteLiteral(@"        <td>Mark</td>
                    <td>Otto</td>
                </tr>
                <tr>
                    <th scope=""row"">2</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                </tr>
                <tr>
                    <th scope=""row"">3</th>
                    <td>Larry</td>
                    <td>the Bird</td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class=""tab-pane fade"" id=""abbrevs"" role=""tabpanel"" aria-labelledby=""profile-tab"">
        <button type=""button"" class=""btn btn-dark mb-1"">Add Abbreviations <i class=""fas fa-plus-circle""></i></button>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">First</th>
                    <th scope=""col"">Last</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">1</th>
       ");
            WriteLiteral(@"             <td>Mark</td>
                    <td>Otto</td>
                </tr>
                <tr>
                    <th scope=""row"">2</th>
                    <td>Jacob</td>
                    <td>Thornton</td>
                </tr>
                <tr>
                    <th scope=""row"">3</th>
                    <td>Larry</td>
                    <td>the Bird</td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
");
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

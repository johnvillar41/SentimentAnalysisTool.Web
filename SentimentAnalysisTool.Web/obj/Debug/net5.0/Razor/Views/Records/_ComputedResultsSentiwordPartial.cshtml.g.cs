#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_ComputedResultsSentiwordPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba44435e585e1de4c33b341cb07180ec1bcc324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Records__ComputedResultsSentiwordPartial), @"mvc.1.0.view", @"/Views/Records/_ComputedResultsSentiwordPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ba44435e585e1de4c33b341cb07180ec1bcc324", @"/Views/Records/_ComputedResultsSentiwordPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Records__ComputedResultsSentiwordPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SentimentAnalysisTool.Data.Models.SentiWordNetModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Modal -->\r\n");
#nullable restore
#line 3 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_ComputedResultsSentiwordPartial.cshtml"
  var i = ViewData["index"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 130, "\"", 149, 2);
            WriteAttributeValue("", 135, "resultModal_", 135, 12, true);
#nullable restore
#line 4 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_ComputedResultsSentiwordPartial.cshtml"
WriteAttributeValue("", 147, i, 147, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">SentiWordNet Computed Results</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p><b>Negative Score: </b>");
#nullable restore
#line 14 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_ComputedResultsSentiwordPartial.cshtml"
                                     Write(Model.NegativeScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Polarity Score: </b>");
#nullable restore
#line 15 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_ComputedResultsSentiwordPartial.cshtml"
                                     Write(Model.PolarityScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Positive Score: </b>");
#nullable restore
#line 16 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_ComputedResultsSentiwordPartial.cshtml"
                                     Write(Model.PositiveScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Sentiment Score: </b>");
#nullable restore
#line 17 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_ComputedResultsSentiwordPartial.cshtml"
                                      Write(Model.SentimentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-dark\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SentimentAnalysisTool.Data.Models.SentiWordNetModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8eca67d6bfe6894cdb910c68cb99ba33764d771"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Records__CommentsPartialSentiwordnet), @"mvc.1.0.view", @"/Views/Records/_CommentsPartialSentiwordnet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8eca67d6bfe6894cdb910c68cb99ba33764d771", @"/Views/Records/_CommentsPartialSentiwordnet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Records__CommentsPartialSentiwordnet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SentimentAnalysisTool.Web.Models.CommentViewModels.CommentSentiWordNetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table table-responsive table-height table-hover"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""col"">Comment Id</th>
            <th scope=""col"">Comment </th>
            <th scope=""col"">Score </th>
            <th scope=""col"">Sentiment </th>
            <th scope=""col"">Date </th>
            <th scope=""col"">Action </th>
            <th scope=""col"">Algorithmn </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 18 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                           Write(Model[i].CommentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
               Write(Model[i].CommentDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 20 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                 if (Model[i].CommentScore >= 1 && Model[i].CommentScore <= 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><span class=\"badge badge-pill badge-danger\">");
#nullable restore
#line 22 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                               Write(Model[i].CommentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</span></td>\r\n");
#nullable restore
#line 23 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                }
                else if (Model[i].CommentScore >= 4 && Model[i].CommentScore <= 5)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><span class=\"badge badge-pill badge-success\">");
#nullable restore
#line 26 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                                Write(Model[i].CommentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</span></td>\r\n");
#nullable restore
#line 27 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><span class=\"badge badge-pill badge-dark\">");
#nullable restore
#line 30 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                             Write(Model[i].CommentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</span></td>\r\n");
#nullable restore
#line 31 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                 if (Model[i].CommentPolarity == SentimentAnalysisTool.Web.Enums.SentimentType.Positive)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><span class=\"badge badge-success\">");
#nullable restore
#line 35 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                     Write(Model[i].CommentPolarity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 36 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                }
                else if (Model[i].CommentPolarity == SentimentAnalysisTool.Web.Enums.SentimentType.Negative)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><span class=\"badge badge-danger\">");
#nullable restore
#line 39 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                    Write(Model[i].CommentPolarity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 40 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><span class=\"badge badge-dark\">");
#nullable restore
#line 43 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                  Write(Model[i].CommentPolarity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 44 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 46 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
               Write(Model[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <!-- Button trigger modal -->\r\n                    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#resultModal_");
#nullable restore
#line 49 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        View computed results\r\n                    </button>\r\n                </td>\r\n                <td>SentiWordNet</td>\r\n            </tr>\r\n            <!-- Modal -->\r\n            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2456, "\"", 2475, 2);
            WriteAttributeValue("", 2461, "resultModal_", 2461, 12, true);
#nullable restore
#line 56 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
WriteAttributeValue("", 2473, i, 2473, 2, false);

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
#line 66 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                 Write(Model[i].SentiWordNetGrade.NegativeScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><b>Polarity Score: </b>");
#nullable restore
#line 67 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                 Write(Model[i].SentiWordNetGrade.PolarityScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><b>Positive Score: </b>");
#nullable restore
#line 68 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                 Write(Model[i].SentiWordNetGrade.PositiveScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><b>Sentiment Score: </b>");
#nullable restore
#line 69 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
                                                  Write(Model[i].SentiWordNetGrade.SentimentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 77 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialSentiwordnet.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<nav aria-label=""Page navigation example"">
    <ul class=""pagination"">
        <li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
    </ul>
</nav>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SentimentAnalysisTool.Web.Models.CommentViewModels.CommentSentiWordNetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

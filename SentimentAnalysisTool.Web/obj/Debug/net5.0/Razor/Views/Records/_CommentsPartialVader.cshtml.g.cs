#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efdf223bbc72eed4bc6acfe66ee59cd8c431b1dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Records__CommentsPartialVader), @"mvc.1.0.view", @"/Views/Records/_CommentsPartialVader.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efdf223bbc72eed4bc6acfe66ee59cd8c431b1dc", @"/Views/Records/_CommentsPartialVader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Records__CommentsPartialVader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SentimentAnalysisTool.Web.Models.CommentViewModels.CommentVaderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No results found!</p>\r\n");
#nullable restore
#line 5 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""table-responsive table-height-comments"">
    <table class=""table table-hover"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"">Comment </th>
                <th scope=""col"">Transformed Comment </th>
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
#line 22 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
             for (int i = 0; i < Model.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                   Write(Model[i].CommentDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                   Write(Model[i].TransformedCommentDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                     if (Model[i].CommentScore >= 1 && Model[i].CommentScore <= 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-pill badge-dark\">");
#nullable restore
#line 29 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                                 Write(Model[i].CommentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</span></td>\r\n");
#nullable restore
#line 30 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                    }
                    else if (Model[i].CommentScore >= 4 && Model[i].CommentScore <= 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-pill badge-light\">");
#nullable restore
#line 33 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                                  Write(Model[i].CommentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</span></td>\r\n");
#nullable restore
#line 34 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-pill badge-secondary\">");
#nullable restore
#line 37 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                                      Write(Model[i].CommentScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</span></td>\r\n");
#nullable restore
#line 38 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                     if (Model[i].CommentPolarity == SentimentAnalysisTool.Web.Enums.SentimentType.Positive)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-light\">");
#nullable restore
#line 42 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                       Write(Model[i].CommentPolarity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-smile\"></i></span></td>\r\n");
#nullable restore
#line 43 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                    }
                    else if (Model[i].CommentPolarity == SentimentAnalysisTool.Web.Enums.SentimentType.Negative)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-dark\">");
#nullable restore
#line 46 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                      Write(Model[i].CommentPolarity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-sad-tear\"></i></span></td>\r\n");
#nullable restore
#line 47 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-secondary\">");
#nullable restore
#line 50 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                           Write(Model[i].CommentPolarity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 51 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                   Write(Model[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <!-- Button trigger modal -->\r\n                        <button type=\"button\" class=\"btn btn-dark\" data-toggle=\"modal\" data-target=\"#resultModal_");
#nullable restore
#line 56 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            View computed results\r\n                        </button>\r\n                    </td>\r\n                    <td>Vader</td>\r\n                </tr>\r\n                <!-- Modal -->\r\n                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2820, "\"", 2839, 2);
            WriteAttributeValue("", 2825, "resultModal_", 2825, 12, true);
#nullable restore
#line 63 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
WriteAttributeValue("", 2837, i, 2837, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""exampleModalLabel"">Vader Computed Results</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"">
                                <p><b>Compound Score: </b>");
#nullable restore
#line 73 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                     Write(Model[i].VaderGrade.CompoundScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p><b>Compound Value: </b>");
#nullable restore
#line 74 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                     Write(Model[i].VaderGrade.CompoundValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p><b>Negative Value: </b>");
#nullable restore
#line 75 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                     Write(Model[i].VaderGrade.NegativeValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p><b>Neutral Value: </b>");
#nullable restore
#line 76 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                    Write(Model[i].VaderGrade.NeutralValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p><b>Positive Value: </b>");
#nullable restore
#line 77 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
                                                     Write(Model[i].VaderGrade.PositiveValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-dark"" data-dismiss=""modal"">Close</button>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 85 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
#nullable restore
#line 89 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsPartialVader.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SentimentAnalysisTool.Web.Models.CommentViewModels.CommentVaderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

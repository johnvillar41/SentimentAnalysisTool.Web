#pragma checksum "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "364339ada36f004bf123b267392de6e76b3e69fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Records__CommentsTransformPartial), @"mvc.1.0.view", @"/Views/Records/_CommentsTransformPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"364339ada36f004bf123b267392de6e76b3e69fe", @"/Views/Records/_CommentsTransformPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e0233095f6598a6f87feba56c16832bdc21bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Records__CommentsTransformPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SentimentAnalysisTool.Web.Models.CommentTransformViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""table-responsive table-height-comments-transform"">
    <table class=""table table-hover"">
        <thead class=""thead-light table-sticky"">
            <tr>
                <th scope=""col"">Original Comment </th>
                <th scope=""col"">Manually Transformed Comment </th>
                <th scope=""col"">Automatically Transformed Comment </th>
                <th scope=""col"">Result</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 13 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 16 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
                   Write(item.OriginalComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
                   Write(item.ManualTransformedComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
                   Write(item.AutomaticTransformedComment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 19 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
                     if (item.IsCommentEqual)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><span class=\"badge badge-pill badge-light\">");
#nullable restore
#line 21 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
                                                                  Write(item.IsCommentEqual);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fas fa-plus-circle\"></i></span></td>\r\n");
#nullable restore
#line 22 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td> <span class=\"badge badge-pill badge-dark\">");
#nullable restore
#line 25 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
                                                                  Write(item.IsCommentEqual);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fas fa-minus-circle\"></i></span></td>\r\n");
#nullable restore
#line 26 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Villar\Desktop\SentimentAnalysisToolFrontEnd\SentimentAnalysisTool.Web\Views\Records\_CommentsTransformPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SentimentAnalysisTool.Web.Models.CommentTransformViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

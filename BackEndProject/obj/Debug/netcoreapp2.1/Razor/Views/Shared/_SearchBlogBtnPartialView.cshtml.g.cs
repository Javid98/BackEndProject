#pragma checksum "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23731c8f3aa8e8d0eb77419762c8fed342c0b421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SearchBlogBtnPartialView), @"mvc.1.0.view", @"/Views/Shared/_SearchBlogBtnPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SearchBlogBtnPartialView.cshtml", typeof(AspNetCore.Views_Shared__SearchBlogBtnPartialView))]
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
#line 1 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.DAL;

#line default
#line hidden
#line 2 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.Models;

#line default
#line hidden
#line 3 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23731c8f3aa8e8d0eb77419762c8fed342c0b421", @"/Views/Shared/_SearchBlogBtnPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de08ed6ded2e8843ca2fb56921055337c5d2ba4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SearchBlogBtnPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
 foreach (Blog blog in Model)
{

#line default
#line hidden
            BeginContext(60, 118, true);
            WriteLiteral("\t<div class=\"allBlog col-md-6 col-sm-6 col-xs-12\">\r\n\t\t<div class=\"single-blog mb-60\">\r\n\t\t\t<div class=\"blog-img\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(178, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc8f092b4f074ece905ac8d51cdf2f4c", async() => {
                BeginContext(225, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f19c12d272342bfa5a49345b7806b87", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 235, "~/img/blog/", 235, 11, true);
#line 7 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
AddHtmlAttributeValue("", 246, blog.ImagePath, 246, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 7 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
                                         WriteLiteral(blog.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(278, 158, true);
            WriteLiteral("\r\n\t\t\t\t<div class=\"blog-hover\">\r\n\t\t\t\t\t<i class=\"fa fa-link\"></i>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"blog-content\">\r\n\t\t\t\t<div class=\"blog-top\">\r\n\t\t\t\t\t<p>By ");
            EndContext();
            BeginContext(437, 21, false);
#line 14 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
                     Write(blog.AppUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(458, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(464, 9, false);
#line 14 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
                                                Write(blog.Date);

#line default
#line hidden
            EndContext();
            BeginContext(473, 38, true);
            WriteLiteral("  /  <i class=\"fa fa-comments-o\"></i> ");
            EndContext();
            BeginContext(512, 17, false);
#line 14 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
                                                                                                Write(blog.CommentCount);

#line default
#line hidden
            EndContext();
            BeginContext(529, 58, true);
            WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"blog-bottom\">\r\n\t\t\t\t\t<h2>");
            EndContext();
            BeginContext(587, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92d46e2482384a4fb1527bf2e57c6f14", async() => {
                BeginContext(635, 10, false);
#line 17 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
                                                                  Write(blog.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
                                                 WriteLiteral(blog.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(649, 12, true);
            WriteLiteral("</h2>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(661, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3093a8d054e4e38a04b89c82183be7d", async() => {
                BeginContext(708, 9, true);
                WriteLiteral("read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
                                             WriteLiteral(blog.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(721, 44, true);
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
            EndContext();
#line 23 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
}

#line default
#line hidden
            BeginContext(768, 74, true);
            WriteLiteral("<div class=\"allPagination col-md-12\">\r\n\t<div class=\"pagination\">\r\n\t\t<ul>\r\n");
            EndContext();
#line 27 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
             for (int i = 1; i <= ViewBag.PageCount; i++)
			{
				if (i == ViewBag.Page)
				{

#line default
#line hidden
            BeginContext(933, 73, true);
            WriteLiteral("\t\t\t\t\t<li style=\"pointer-events:none;\"><a style=\"background-color:#e6e6e6\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1006, "\"", 1036, 2);
            WriteAttributeValue("", 1013, "/Blog/SearchBtn?page=", 1013, 21, true);
#line 31 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
WriteAttributeValue("", 1034, i, 1034, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1037, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1039, 1, false);
#line 31 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
                                                                                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 32 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
				}
				else
				{

#line default
#line hidden
            BeginContext(1075, 11, true);
            WriteLiteral("\t\t\t\t\t<li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1086, "\"", 1143, 4);
            WriteAttributeValue("", 1093, "/Blog/SearchBtn?page=", 1093, 21, true);
#line 35 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
WriteAttributeValue("", 1114, i, 1114, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 1116, "&search=", 1116, 8, true);
#line 35 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
WriteAttributeValue("", 1124, ViewBag.SearchText, 1124, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1144, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1146, 1, false);
#line 35 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
                                                                                Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 36 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Shared\_SearchBlogBtnPartialView.cshtml"
				}
			}

#line default
#line hidden
            BeginContext(1171, 26, true);
            WriteLiteral("\r\n\t\t</ul>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591

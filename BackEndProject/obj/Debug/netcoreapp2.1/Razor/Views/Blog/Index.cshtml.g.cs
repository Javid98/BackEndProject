#pragma checksum "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4f8ff805408a2bbedc10f2d49d37c7f0f6b998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Index.cshtml", typeof(AspNetCore.Views_Blog_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb4f8ff805408a2bbedc10f2d49d37c7f0f6b998", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3044f171676ff74b3c74fae559f191d10dbe2222", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:70px !important;width:100px !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(52, 730, true);
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>blog / right side bar</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""row allBlogParent"">
");
            EndContext();
#line 29 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                     foreach (Blog blog in Model.Blogs)
                    {

#line default
#line hidden
            BeginContext(862, 228, true);
            WriteLiteral("                        <div class=\"allBlog col-md-6 col-sm-6 col-xs-12\">\r\n                            <div class=\"single-blog mb-60\">\r\n                                <div class=\"blog-img\">\r\n                                    ");
            EndContext();
            BeginContext(1090, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45518d5e0fd640778d079a163c429e39", async() => {
                BeginContext(1137, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1eab055578434003ae8bd68da05ea07a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1147, "~/img/blog/", 1147, 11, true);
#line 34 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1158, blog.ImagePath, 1158, 15, false);

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
#line 34 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
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
            BeginContext(1190, 382, true);
            WriteLiteral(@"
                                    <div class=""blog-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </div>
                                <div class=""blog-content"">
                                    <div class=""blog-top"">
                                        <p>By ");
            EndContext();
            BeginContext(1573, 21, false);
#line 41 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                         Write(blog.AppUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1594, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(1600, 9, false);
#line 41 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                    Write(blog.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1609, 38, true);
            WriteLiteral("  /  <i class=\"fa fa-comments-o\"></i> ");
            EndContext();
            BeginContext(1648, 17, false);
#line 41 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                                                                    Write(blog.CommentCount);

#line default
#line hidden
            EndContext();
            BeginContext(1665, 157, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"blog-bottom\">\r\n                                        <h2>");
            EndContext();
            BeginContext(1822, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0881cf468582479bb6f78be3571740ed", async() => {
                BeginContext(1870, 10, false);
#line 44 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
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
#line 44 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
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
            BeginContext(1884, 47, true);
            WriteLiteral("</h2>\r\n                                        ");
            EndContext();
            BeginContext(1931, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb1769783e349b0abac5774bdd584cb", async() => {
                BeginContext(1978, 9, true);
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
#line 45 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
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
            BeginContext(1991, 154, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 50 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2168, 143, true);
            WriteLiteral("                    <div class=\"allPagination col-md-12\">\r\n                        <div class=\"pagination\">\r\n                            <ul>\r\n");
            EndContext();
#line 54 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                 for (int i = 1; i <= ViewBag.PageCount; i++)
                                {
                                    if (i == ViewBag.Page)
                                    {

#line default
#line hidden
            BeginContext(2524, 108, true);
            WriteLiteral("                                        <li style=\"pointer-events:none;\"><a style=\"background-color:#e6e6e6\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2632, "\"", 2658, 2);
            WriteAttributeValue("", 2639, "/Blog/Index?page=", 2639, 17, true);
#line 58 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2656, i, 2656, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2659, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2661, 1, false);
#line 58 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2662, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 59 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2793, 46, true);
            WriteLiteral("                                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2839, "\"", 2865, 2);
            WriteAttributeValue("", 2846, "/Blog/Index?page=", 2846, 17, true);
#line 62 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2863, i, 2863, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2866, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2868, 1, false);
#line 62 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2869, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 63 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(2954, 503, true);
            WriteLiteral(@"
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget mb-50"">
                        <h3>search</h3>
                        <div class=""blog-search"">
                            <span class=""alert alert-danger errorText"" style=""display:none""></span>
                            ");
            EndContext();
            BeginContext(3457, 551, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888cc498b7d24c29a5ac6a845b0c957e", async() => {
                BeginContext(3486, 515, true);
                WriteLiteral(@"
                                <input id=""searchTextBlogv2"" type=""search"" placeholder=""Search..."" name=""search"" />
                                <ul id=""searchULv2"" style=""position:absolute;background-color:whitesmoke;width:258px;z-index:15;"">
                                </ul>
                                <button id=""searchBlogBtn"" type=""submit"">
                                    <span><i class=""fa fa-search""></i></span>
                                </button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4008, 821, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <h3>categories</h3>
                        <ul>
                            <li><a href=""#"">CSS Engineering (10)</a></li>
                            <li><a href=""#"">Political Science (12)</a></li>
                            <li><a href=""#"">Micro Biology (08)</a></li>
                            <li><a href=""#"">HTML5 &amp; CSS3 (15)</a></li>
                            <li><a href=""#"">Web Design (20)</a></li>
                            <li><a href=""#"">PHP (23)</a></li>
                        </ul>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <div class=""single-blog-banner"">
                            ");
            EndContext();
            BeginContext(4829, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b53fec3705144c11a3146debc11a2c09", async() => {
                BeginContext(4919, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3ba51e1697084c7391c91d625a97b1b6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4929, "~/img/blog/", 4929, 11, true);
#line 100 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 4940, Model.BestTheme.ImagePath, 4940, 26, false);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                           WriteLiteral(Model.BestTheme.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4983, 229, true);
            WriteLiteral("\n                            <h2>best<br> eductaion<br> theme</h2>\n                        </div>\n                    </div>\n                    <div class=\"single-blog-widget mb-50\">\n                        <h3>latest post</h3>\n");
            EndContext();
#line 106 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                         foreach (var post in Model.LatestPosts)
                        {

#line default
#line hidden
            BeginContext(5303, 158, true);
            WriteLiteral("                            <div class=\"single-post mb-30\">\n                                <div class=\"single-post-img\">\n                                    ");
            EndContext();
            BeginContext(5461, 438, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8d7fe107cf4692829d0228d1131b49", async() => {
                BeginContext(5530, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(5571, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a6aabb9627054744a6be422fecdcdc15", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5636, "~/img/blog/", 5636, 11, true);
#line 111 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 5647, post.ImagePath, 5647, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5675, 220, true);
                WriteLiteral("\n                                        <div class=\"blog-hover\">\n                                            <i class=\"fa fa-link\"></i>\n                                        </div>\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 110 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                                   WriteLiteral(post.Id);

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
            BeginContext(5899, 146, true);
            WriteLiteral("\n                                </div>\n                                <div class=\"single-post-content\">\n                                    <h4>");
            EndContext();
            BeginContext(6045, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f34ba1e11114ecabd23c763e951dd3d", async() => {
                BeginContext(6115, 10, false);
#line 118 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                                                        Write(post.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                                       WriteLiteral(post.Id);

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
            BeginContext(6129, 48, true);
            WriteLiteral("</h4>\n                                    <p>By ");
            EndContext();
            BeginContext(6178, 21, false);
#line 119 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                     Write(post.AppUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(6199, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(6205, 9, false);
#line 119 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                Write(post.Date);

#line default
#line hidden
            EndContext();
            BeginContext(6214, 79, true);
            WriteLiteral("</p>\n                                </div>\n                            </div>\n");
            EndContext();
#line 122 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(6319, 120, true);
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- Blog End -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbef2bd63b9c8876f3df6d3f48a8124340ce9cc7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbef2bd63b9c8876f3df6d3f48a8124340ce9cc7", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de08ed6ded2e8843ca2fb56921055337c5d2ba4", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 575, true);
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
            BeginContext(678, 138, true);
            WriteLiteral("\t\t\t\t\t\t<div class=\"allBlog col-md-6 col-sm-6 col-xs-12\">\r\n\t\t\t\t\t\t\t<div class=\"single-blog mb-60\">\r\n\t\t\t\t\t\t\t\t<div class=\"blog-img\">\r\n\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(816, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2132d28307f5401690f5e322753d16c1", async() => {
                BeginContext(863, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "19feeeeb1e9a424b8f10c8bbaf57a01d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 873, "~/img/blog/", 873, 11, true);
#line 34 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 884, blog.ImagePath, 884, 15, false);

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
            BeginContext(916, 193, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<div class=\"blog-hover\">\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-link\"></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"blog-content\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"blog-top\">\r\n\t\t\t\t\t\t\t\t\t\t<p>By ");
            EndContext();
            BeginContext(1110, 21, false);
#line 41 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                         Write(blog.AppUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1131, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(1137, 9, false);
#line 41 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                    Write(blog.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1146, 38, true);
            WriteLiteral("  /  <i class=\"fa fa-comments-o\"></i> ");
            EndContext();
            BeginContext(1185, 17, false);
#line 41 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                                                                    Write(blog.CommentCount);

#line default
#line hidden
            EndContext();
            BeginContext(1202, 73, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"blog-bottom\">\r\n\t\t\t\t\t\t\t\t\t\t<h2>");
            EndContext();
            BeginContext(1275, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6289f321ad2b49a6bd4b757f9240b441", async() => {
                BeginContext(1323, 10, false);
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
            BeginContext(1337, 17, true);
            WriteLiteral("</h2>\r\n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1354, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8490639e819640fd8f4f7b107082cffd", async() => {
                BeginContext(1401, 9, true);
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
            BeginContext(1414, 64, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 50 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(1486, 89, true);
            WriteLiteral("\t\t\t\t\t<div class=\"allPagination col-md-12\">\r\n\t\t\t\t\t\t<div class=\"pagination\">\r\n\t\t\t\t\t\t\t<ul>\r\n");
            EndContext();
#line 54 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                 for (int i = 1; i <= ViewBag.PageCount; i++)
								{
									if (i == ViewBag.Page)
									{

#line default
#line hidden
            BeginContext(1686, 78, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<li style=\"pointer-events:none;\"><a style=\"background-color:#e6e6e6\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1764, "\"", 1790, 2);
            WriteAttributeValue("", 1771, "/Blog/Index?page=", 1771, 17, true);
#line 58 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1788, i, 1788, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1791, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1793, 1, false);
#line 58 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1794, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 59 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
									}
									else
									{

#line default
#line hidden
            BeginContext(1844, 16, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1860, "\"", 1886, 2);
            WriteAttributeValue("", 1867, "/Blog/Index?page=", 1867, 17, true);
#line 62 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1884, i, 1884, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1887, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1889, 1, false);
#line 62 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1890, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 63 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
									}
								}

#line default
#line hidden
            BeginContext(1924, 319, true);
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
            BeginContext(2243, 393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56300ccc60d64f5e83c17619245e4301", async() => {
                BeginContext(2275, 354, true);
                WriteLiteral(@"
								<input id=""searchTextBlogv2"" type=""search"" placeholder=""Search..."" name=""searchBlogBtn"" />
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2636, 539, true);
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
            BeginContext(3175, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86540600189247fa9448e23beca12e27", async() => {
                BeginContext(3265, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90d838d692074f5682cf8b76f680c1ec", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3275, "~/img/blog/", 3275, 11, true);
#line 100 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 3286, Model.BestTheme.ImagePath, 3286, 26, false);

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
            BeginContext(3329, 148, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t<h2>best<br> eductaion<br> theme</h2>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"single-blog-widget mb-50\">\r\n\t\t\t\t\t\t<h3>latest post</h3>\r\n");
            EndContext();
#line 106 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                         foreach (var post in Model.LatestPosts)
						{

#line default
#line hidden
            BeginContext(3534, 88, true);
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"single-post mb-30\">\r\n\t\t\t\t\t\t\t\t<div class=\"single-post-img\">\r\n\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3622, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66a7ad44910045539b31f09c9973b669", async() => {
                BeginContext(3691, 12, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(3703, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "44f3112f8258416f88b8f643e9520229", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3768, "~/img/blog/", 3768, 11, true);
#line 111 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 3779, post.ImagePath, 3779, 15, false);

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
                BeginContext(3807, 104, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"blog-hover\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-link\"></i>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
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
            BeginContext(3915, 74, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"single-post-content\">\r\n\t\t\t\t\t\t\t\t\t<h4>");
            EndContext();
            BeginContext(3989, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a772fad09c94473db5da24fcdc4bbf4a", async() => {
                BeginContext(4059, 10, false);
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
            BeginContext(4073, 22, true);
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t<p>By ");
            EndContext();
            BeginContext(4096, 21, false);
#line 119 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                     Write(post.AppUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4117, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(4123, 9, false);
#line 119 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
                                                                Write(post.Date);

#line default
#line hidden
            EndContext();
            BeginContext(4132, 37, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 122 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Blog\Index.cshtml"
						}

#line default
#line hidden
            BeginContext(4178, 82, true);
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n<!-- Blog End -->\r\n");
            EndContext();
            BeginContext(4337, 2, true);
            WriteLiteral("\r\n");
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

#pragma checksum "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb72ca43a023146a512c7430d6bd6d8d15626fba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminEduHome_Views_Course_Detail), @"mvc.1.0.view", @"/Areas/AdminEduHome/Views/Course/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminEduHome/Views/Course/Detail.cshtml", typeof(AspNetCore.Areas_AdminEduHome_Views_Course_Detail))]
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
#line 1 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\_ViewImports.cshtml"
using BackEndProject.DAL;

#line default
#line hidden
#line 2 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\_ViewImports.cshtml"
using BackEndProject.Models;

#line default
#line hidden
#line 3 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\_ViewImports.cshtml"
using BackEndProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb72ca43a023146a512c7430d6bd6d8d15626fba", @"/Areas/AdminEduHome/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de08ed6ded2e8843ca2fb56921055337c5d2ba4", @"/Areas/AdminEduHome/Views/_ViewImports.cshtml")]
    public class Areas_AdminEduHome_Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("450"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(57, 40, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Course Image</h4>\r\n    ");
            EndContext();
            BeginContext(97, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "212fb4047b804079b125f33c57af5801", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 107, "~/img/course/", 107, 13, true);
#line 8 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 120, Model.ImagePath, 120, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(173, 74, true);
            WriteLiteral("\r\n</div>\r\n<div style=\"margin-top:30px\">\r\n    <h4>Course name</h4>\r\n    <p>");
            EndContext();
            BeginContext(248, 10, false);
#line 12 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(258, 85, true);
            WriteLiteral("</p>\r\n</div>\r\n<div style=\"margin-top:30px\">\r\n    <h4>Course description</h4>\r\n    <p>");
            EndContext();
            BeginContext(344, 27, false);
#line 16 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
  Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(371, 79, true);
            WriteLiteral("</p>\r\n</div>\r\n<div style=\"margin-top:30px\">\r\n    <h4>About course</h4>\r\n    <p>");
            EndContext();
            BeginContext(451, 41, false);
#line 20 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
  Write(Html.Raw(Model.CourseContent.AboutCourse));

#line default
#line hidden
            EndContext();
            BeginContext(492, 79, true);
            WriteLiteral("</p>\r\n</div>\r\n<div style=\"margin-top:30px\">\r\n    <h4>How to Apply</h4>\r\n    <p>");
            EndContext();
            BeginContext(572, 33, false);
#line 24 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
  Write(Html.Raw(Model.CourseContent.HTA));

#line default
#line hidden
            EndContext();
            BeginContext(605, 80, true);
            WriteLiteral("</p>\r\n</div>\r\n<div style=\"margin-top:30px\">\r\n    <h4>Certification</h4>\r\n    <p>");
            EndContext();
            BeginContext(686, 43, false);
#line 28 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
  Write(Html.Raw(Model.CourseContent.Certification));

#line default
#line hidden
            EndContext();
            BeginContext(729, 159, true);
            WriteLiteral("</p>\r\n</div>\r\n<div style=\"margin-top:30px\">\r\n    <ul style=\"list-style-type:none\">\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Starts</strong>: ");
            EndContext();
            BeginContext(889, 26, false);
#line 33 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
                                Write(Model.CourseFeature.Starts);

#line default
#line hidden
            EndContext();
            BeginContext(915, 94, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Duration:</strong> ");
            EndContext();
            BeginContext(1010, 28, false);
#line 36 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
                                  Write(Model.CourseFeature.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 100, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Class duration:</strong> ");
            EndContext();
            BeginContext(1139, 33, false);
#line 39 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
                                        Write(Model.CourseFeature.ClassDuration);

#line default
#line hidden
            EndContext();
            BeginContext(1172, 97, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Skill level:</strong> ");
            EndContext();
            BeginContext(1270, 30, false);
#line 42 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
                                     Write(Model.CourseFeature.SkillLevel);

#line default
#line hidden
            EndContext();
            BeginContext(1300, 94, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Language:</strong> ");
            EndContext();
            BeginContext(1395, 29, false);
#line 45 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
                                  Write(Model.CourseFeature.Langugage);

#line default
#line hidden
            EndContext();
            BeginContext(1424, 94, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Students:</strong> ");
            EndContext();
            BeginContext(1519, 28, false);
#line 48 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
                                  Write(Model.CourseFeature.Students);

#line default
#line hidden
            EndContext();
            BeginContext(1547, 96, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Assesments:</strong> ");
            EndContext();
            BeginContext(1644, 30, false);
#line 51 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
                                    Write(Model.CourseFeature.Assesments);

#line default
#line hidden
            EndContext();
            BeginContext(1674, 89, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Fee:</strong> ");
            EndContext();
            BeginContext(1764, 23, false);
#line 54 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Course\Detail.cshtml"
                             Write(Model.CourseFeature.Fee);

#line default
#line hidden
            EndContext();
            BeginContext(1787, 83, true);
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</div>\r\n<div class=\"row\" style=\"margin-top:20px\">\r\n    ");
            EndContext();
            BeginContext(1870, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7f7148e37c6451694caddd00c346488", async() => {
                BeginContext(1913, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1924, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbfc5216af0f60eca5a7c9f00b013c0b3ddb3888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminEduHome_Views_Teacher_Detail), @"mvc.1.0.view", @"/Areas/AdminEduHome/Views/Teacher/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminEduHome/Views/Teacher/Detail.cshtml", typeof(AspNetCore.Areas_AdminEduHome_Views_Teacher_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbfc5216af0f60eca5a7c9f00b013c0b3ddb3888", @"/Areas/AdminEduHome/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de08ed6ded2e8843ca2fb56921055337c5d2ba4", @"/Areas/AdminEduHome/Views/_ViewImports.cshtml")]
    public class Areas_AdminEduHome_Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
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
#line 2 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(58, 41, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Teacher Image</h4>\r\n    ");
            EndContext();
            BeginContext(99, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fee9a05c282460c807a5794839cbc93", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 109, "~/img/teacher/", 109, 14, true);
#line 8 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 123, Model.ImagePath, 123, 16, false);

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
            BeginContext(176, 79, true);
            WriteLiteral("\r\n</div>\r\n<div style=\"margin-top:40px\">\r\n    <h4>Teacher Fullname</h4>\r\n    <p>");
            EndContext();
            BeginContext(256, 14, false);
#line 12 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
  Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(270, 85, true);
            WriteLiteral("</p>\r\n</div>\r\n<div style=\"margin-top:40px\">\r\n    <h4>Teacher Profession</h4>\r\n    <p>");
            EndContext();
            BeginContext(356, 16, false);
#line 16 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
  Write(Model.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(372, 80, true);
            WriteLiteral("</p>\r\n</div>\r\n<div style=\"margin-top:40px\">\r\n    <h4>About teacher</h4>\r\n    <p>");
            EndContext();
            BeginContext(453, 21, false);
#line 20 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
  Write(Html.Raw(Model.About));

#line default
#line hidden
            EndContext();
            BeginContext(474, 160, true);
            WriteLiteral("</p>\r\n</div>\r\n<div style=\"margin-top:40px\">\r\n    <ul style=\"list-style-type:none\">\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Degree:</strong>: ");
            EndContext();
            BeginContext(635, 12, false);
#line 25 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                 Write(Model.Degree);

#line default
#line hidden
            EndContext();
            BeginContext(647, 96, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Experience:</strong> ");
            EndContext();
            BeginContext(744, 16, false);
#line 28 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                    Write(Model.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(760, 93, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Hobbies:</strong> ");
            EndContext();
            BeginContext(854, 13, false);
#line 31 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                 Write(Model.Hobbies);

#line default
#line hidden
            EndContext();
            BeginContext(867, 93, true);
            WriteLiteral("\r\n        </li>\r\n        <li style=\"margin-top:10px\">\r\n            <strong>Faculty:</strong> ");
            EndContext();
            BeginContext(961, 13, false);
#line 34 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                 Write(Model.Faculty);

#line default
#line hidden
            EndContext();
            BeginContext(974, 484, true);
            WriteLiteral(@"
        </li>
    </ul>
</div>
<div class=""col-md-9 col-sm-8 mt-5"">
    <div class=""skill-area"">
        <h4>skills</h4>
    </div>
    <div class=""skill-wrapper"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <div class=""skill-bar-item"">
                    <span>Language</span>
                    <div class=""progress"" style=""height:13px;border-radius:12px"">
                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1458, "\"", 1601, 11);
            WriteAttributeValue("", 1466, "width:", 1466, 6, true);
#line 48 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 1472, Model.TeacherSkill.Language, 1473, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1501, "%;", 1501, 2, true);
            WriteAttributeValue(" ", 1503, "visibility:", 1504, 12, true);
            WriteAttributeValue(" ", 1515, "visible;", 1516, 9, true);
            WriteAttributeValue(" ", 1524, "animation-duration:", 1525, 20, true);
            WriteAttributeValue(" ", 1544, "1.5s;", 1545, 6, true);
            WriteAttributeValue(" ", 1550, "animation-delay:", 1551, 17, true);
            WriteAttributeValue(" ", 1567, "1.2s;", 1568, 6, true);
            WriteAttributeValue(" ", 1573, "animation-name:", 1574, 16, true);
            WriteAttributeValue(" ", 1589, "fadeInLeft;", 1590, 12, true);
            EndWriteAttribute();
            BeginContext(1602, 110, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                            <span class=\"text-top\">");
            EndContext();
            BeginContext(1713, 27, false);
#line 49 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                              Write(Model.TeacherSkill.Language);

#line default
#line hidden
            EndContext();
            BeginContext(1740, 401, true);
            WriteLiteral(@"%</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-4"">
                <div class=""skill-bar-item"">
                    <span>Team Leader</span>
                    <div class=""progress"" style=""height:13px;border-radius:12px;"">
                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2141, "\"", 2286, 11);
            WriteAttributeValue("", 2149, "width:", 2149, 6, true);
#line 58 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 2155, Model.TeacherSkill.TeamLeader, 2156, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 2186, "%;", 2186, 2, true);
            WriteAttributeValue(" ", 2188, "visibility:", 2189, 12, true);
            WriteAttributeValue(" ", 2200, "visible;", 2201, 9, true);
            WriteAttributeValue(" ", 2209, "animation-duration:", 2210, 20, true);
            WriteAttributeValue(" ", 2229, "1.5s;", 2230, 6, true);
            WriteAttributeValue(" ", 2235, "animation-delay:", 2236, 17, true);
            WriteAttributeValue(" ", 2252, "1.2s;", 2253, 6, true);
            WriteAttributeValue(" ", 2258, "animation-name:", 2259, 16, true);
            WriteAttributeValue(" ", 2274, "fadeInLeft;", 2275, 12, true);
            EndWriteAttribute();
            BeginContext(2287, 110, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                            <span class=\"text-top\">");
            EndContext();
            BeginContext(2398, 29, false);
#line 59 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                              Write(Model.TeacherSkill.TeamLeader);

#line default
#line hidden
            EndContext();
            BeginContext(2427, 400, true);
            WriteLiteral(@"%</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-4"">
                <div class=""skill-bar-item"">
                    <span>Development</span>
                    <div class=""progress"" style=""height:13px;border-radius:12px"">
                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2827, "\"", 2973, 11);
            WriteAttributeValue("", 2835, "width:", 2835, 6, true);
#line 68 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 2841, Model.TeacherSkill.Development, 2842, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 2873, "%;", 2873, 2, true);
            WriteAttributeValue(" ", 2875, "visibility:", 2876, 12, true);
            WriteAttributeValue(" ", 2887, "visible;", 2888, 9, true);
            WriteAttributeValue(" ", 2896, "animation-duration:", 2897, 20, true);
            WriteAttributeValue(" ", 2916, "1.5s;", 2917, 6, true);
            WriteAttributeValue(" ", 2922, "animation-delay:", 2923, 17, true);
            WriteAttributeValue(" ", 2939, "1.2s;", 2940, 6, true);
            WriteAttributeValue(" ", 2945, "animation-name:", 2946, 16, true);
            WriteAttributeValue(" ", 2961, "fadeInLeft;", 2962, 12, true);
            EndWriteAttribute();
            BeginContext(2974, 110, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                            <span class=\"text-top\">");
            EndContext();
            BeginContext(3085, 30, false);
#line 69 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                              Write(Model.TeacherSkill.Development);

#line default
#line hidden
            EndContext();
            BeginContext(3115, 400, true);
            WriteLiteral(@"%</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-4 mt-3"">
                <div class=""skill-bar-item"">
                    <span>Design</span>
                    <div class=""progress"" style=""height:13px;border-radius:12px"">
                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3515, "\"", 3656, 11);
            WriteAttributeValue("", 3523, "width:", 3523, 6, true);
#line 78 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3529, Model.TeacherSkill.Design, 3530, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 3556, "%;", 3556, 2, true);
            WriteAttributeValue(" ", 3558, "visibility:", 3559, 12, true);
            WriteAttributeValue(" ", 3570, "visible;", 3571, 9, true);
            WriteAttributeValue(" ", 3579, "animation-duration:", 3580, 20, true);
            WriteAttributeValue(" ", 3599, "1.5s;", 3600, 6, true);
            WriteAttributeValue(" ", 3605, "animation-delay:", 3606, 17, true);
            WriteAttributeValue(" ", 3622, "1.2s;", 3623, 6, true);
            WriteAttributeValue(" ", 3628, "animation-name:", 3629, 16, true);
            WriteAttributeValue(" ", 3644, "fadeInLeft;", 3645, 12, true);
            EndWriteAttribute();
            BeginContext(3657, 110, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                            <span class=\"text-top\">");
            EndContext();
            BeginContext(3768, 25, false);
#line 79 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                              Write(Model.TeacherSkill.Design);

#line default
#line hidden
            EndContext();
            BeginContext(3793, 404, true);
            WriteLiteral(@"%</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-4 mt-3"">
                <div class=""skill-bar-item"">
                    <span>Innovation</span>
                    <div class=""progress"" style=""height:13px;border-radius:12px"">
                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4197, "\"", 4342, 11);
            WriteAttributeValue("", 4205, "width:", 4205, 6, true);
#line 88 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 4211, Model.TeacherSkill.Innovation, 4212, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 4242, "%;", 4242, 2, true);
            WriteAttributeValue(" ", 4244, "visibility:", 4245, 12, true);
            WriteAttributeValue(" ", 4256, "visible;", 4257, 9, true);
            WriteAttributeValue(" ", 4265, "animation-duration:", 4266, 20, true);
            WriteAttributeValue(" ", 4285, "1.5s;", 4286, 6, true);
            WriteAttributeValue(" ", 4291, "animation-delay:", 4292, 17, true);
            WriteAttributeValue(" ", 4308, "1.2s;", 4309, 6, true);
            WriteAttributeValue(" ", 4314, "animation-name:", 4315, 16, true);
            WriteAttributeValue(" ", 4330, "fadeInLeft;", 4331, 12, true);
            EndWriteAttribute();
            BeginContext(4343, 110, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                            <span class=\"text-top\">");
            EndContext();
            BeginContext(4454, 29, false);
#line 89 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                              Write(Model.TeacherSkill.Innovation);

#line default
#line hidden
            EndContext();
            BeginContext(4483, 406, true);
            WriteLiteral(@"%</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-4 mt-3"">
                <div class=""skill-bar-item"">
                    <span>Communication</span>
                    <div class=""progress""style=""height:13px;border-radius:12px"">
                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4889, "\"", 5037, 11);
            WriteAttributeValue("", 4897, "width:", 4897, 6, true);
#line 98 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 4903, Model.TeacherSkill.Communication, 4904, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 4937, "%;", 4937, 2, true);
            WriteAttributeValue(" ", 4939, "visibility:", 4940, 12, true);
            WriteAttributeValue(" ", 4951, "visible;", 4952, 9, true);
            WriteAttributeValue(" ", 4960, "animation-duration:", 4961, 20, true);
            WriteAttributeValue(" ", 4980, "1.5s;", 4981, 6, true);
            WriteAttributeValue(" ", 4986, "animation-delay:", 4987, 17, true);
            WriteAttributeValue(" ", 5003, "1.2s;", 5004, 6, true);
            WriteAttributeValue(" ", 5009, "animation-name:", 5010, 16, true);
            WriteAttributeValue(" ", 5025, "fadeInLeft;", 5026, 12, true);
            EndWriteAttribute();
            BeginContext(5038, 110, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                            <span class=\"text-top\">");
            EndContext();
            BeginContext(5149, 32, false);
#line 99 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Teacher\Detail.cshtml"
                                              Write(Model.TeacherSkill.Communication);

#line default
#line hidden
            EndContext();
            BeginContext(5181, 197, true);
            WriteLiteral("%</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\" style=\"margin-top:20px\">\r\n    ");
            EndContext();
            BeginContext(5378, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4713f45dc4e4451cb4a38abb90f3f10c", async() => {
                BeginContext(5421, 7, true);
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
            BeginContext(5432, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591

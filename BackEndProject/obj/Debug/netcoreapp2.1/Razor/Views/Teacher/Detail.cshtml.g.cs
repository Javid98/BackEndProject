#pragma checksum "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd19f8c901cae3055c6f4e34dbcefe04d92b87e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Detail.cshtml", typeof(AspNetCore.Views_Teacher_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd19f8c901cae3055c6f4e34dbcefe04d92b87e0", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de08ed6ded2e8843ca2fb56921055337c5d2ba4", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(58, 801, true);
            WriteLiteral(@"<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            EndContext();
            BeginContext(859, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e863c22e3c014524b547a9bfe0ff3470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 869, "~/img/teacher/", 869, 14, true);
#line 28 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 883, Model.ImagePath, 883, 16, false);

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
            BeginContext(915, 186, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
            EndContext();
            BeginContext(1102, 14, false);
#line 33 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                   Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1116, 31, true);
            WriteLiteral("</h2>\r\n                    <h5>");
            EndContext();
            BeginContext(1148, 16, false);
#line 34 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(1164, 69, true);
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
            EndContext();
            BeginContext(1234, 11, false);
#line 36 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                  Write(Model.About);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 81, true);
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
            EndContext();
            BeginContext(1327, 12, false);
#line 38 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
            EndContext();
            BeginContext(1339, 60, true);
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
            EndContext();
            BeginContext(1400, 16, false);
#line 39 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                                Write(Model.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(1416, 57, true);
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
            EndContext();
            BeginContext(1474, 13, false);
#line 40 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                             Write(Model.Hobbies);

#line default
#line hidden
            EndContext();
            BeginContext(1487, 57, true);
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
            EndContext();
            BeginContext(1545, 13, false);
#line 41 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                             Write(Model.Faculty);

#line default
#line hidden
            EndContext();
            BeginContext(1558, 309, true);
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
            EndContext();
            BeginContext(1868, 26, false);
#line 50 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                         Write(Model.TeacherContact.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1894, 56, true);
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
            EndContext();
            BeginContext(1951, 32, false);
#line 51 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                             Write(Model.TeacherContact.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1983, 51, true);
            WriteLiteral("</p>\r\n                    <p><span>skype : </span> ");
            EndContext();
            BeginContext(2035, 26, false);
#line 52 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                        Write(Model.TeacherContact.Skype);

#line default
#line hidden
            EndContext();
            BeginContext(2061, 62, true);
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2123, "\"", 2160, 1);
#line 54 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2130, Model.TeacherContact.Facebook, 2130, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2161, 76, true);
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2237, "\"", 2275, 1);
#line 55 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2244, Model.TeacherContact.Pinterest, 2244, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2276, 77, true);
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2353, "\"", 2389, 1);
#line 56 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2360, Model.TeacherContact.Twitter, 2360, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2390, 652, true);
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3042, "\"", 3185, 11);
            WriteAttributeValue("", 3050, "width:", 3050, 6, true);
#line 70 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3056, Model.TeacherSkill.Language, 3057, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 3085, "%;", 3085, 2, true);
            WriteAttributeValue(" ", 3087, "visibility:", 3088, 12, true);
            WriteAttributeValue(" ", 3099, "visible;", 3100, 9, true);
            WriteAttributeValue(" ", 3108, "animation-duration:", 3109, 20, true);
            WriteAttributeValue(" ", 3128, "1.5s;", 3129, 6, true);
            WriteAttributeValue(" ", 3134, "animation-delay:", 3135, 17, true);
            WriteAttributeValue(" ", 3151, "1.2s;", 3152, 6, true);
            WriteAttributeValue(" ", 3157, "animation-name:", 3158, 16, true);
            WriteAttributeValue(" ", 3173, "fadeInLeft;", 3174, 12, true);
            EndWriteAttribute();
            BeginContext(3186, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(3309, 27, false);
#line 71 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherSkill.Language);

#line default
#line hidden
            EndContext();
            BeginContext(3336, 469, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3805, "\"", 3950, 11);
            WriteAttributeValue("", 3813, "width:", 3813, 6, true);
#line 80 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3819, Model.TeacherSkill.TeamLeader, 3820, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 3850, "%;", 3850, 2, true);
            WriteAttributeValue(" ", 3852, "visibility:", 3853, 12, true);
            WriteAttributeValue(" ", 3864, "visible;", 3865, 9, true);
            WriteAttributeValue(" ", 3873, "animation-duration:", 3874, 20, true);
            WriteAttributeValue(" ", 3893, "1.5s;", 3894, 6, true);
            WriteAttributeValue(" ", 3899, "animation-delay:", 3900, 17, true);
            WriteAttributeValue(" ", 3916, "1.2s;", 3917, 6, true);
            WriteAttributeValue(" ", 3922, "animation-name:", 3923, 16, true);
            WriteAttributeValue(" ", 3938, "fadeInLeft;", 3939, 12, true);
            EndWriteAttribute();
            BeginContext(3951, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(4074, 29, false);
#line 81 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherSkill.TeamLeader);

#line default
#line hidden
            EndContext();
            BeginContext(4103, 469, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4572, "\"", 4718, 11);
            WriteAttributeValue("", 4580, "width:", 4580, 6, true);
#line 90 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 4586, Model.TeacherSkill.Development, 4587, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 4618, "%;", 4618, 2, true);
            WriteAttributeValue(" ", 4620, "visibility:", 4621, 12, true);
            WriteAttributeValue(" ", 4632, "visible;", 4633, 9, true);
            WriteAttributeValue(" ", 4641, "animation-duration:", 4642, 20, true);
            WriteAttributeValue(" ", 4661, "1.5s;", 4662, 6, true);
            WriteAttributeValue(" ", 4667, "animation-delay:", 4668, 17, true);
            WriteAttributeValue(" ", 4684, "1.2s;", 4685, 6, true);
            WriteAttributeValue(" ", 4690, "animation-name:", 4691, 16, true);
            WriteAttributeValue(" ", 4706, "fadeInLeft;", 4707, 12, true);
            EndWriteAttribute();
            BeginContext(4719, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(4842, 30, false);
#line 91 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherSkill.Development);

#line default
#line hidden
            EndContext();
            BeginContext(4872, 464, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 5336, "\"", 5477, 11);
            WriteAttributeValue("", 5344, "width:", 5344, 6, true);
#line 100 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 5350, Model.TeacherSkill.Design, 5351, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 5377, "%;", 5377, 2, true);
            WriteAttributeValue(" ", 5379, "visibility:", 5380, 12, true);
            WriteAttributeValue(" ", 5391, "visible;", 5392, 9, true);
            WriteAttributeValue(" ", 5400, "animation-duration:", 5401, 20, true);
            WriteAttributeValue(" ", 5420, "1.5s;", 5421, 6, true);
            WriteAttributeValue(" ", 5426, "animation-delay:", 5427, 17, true);
            WriteAttributeValue(" ", 5443, "1.2s;", 5444, 6, true);
            WriteAttributeValue(" ", 5449, "animation-name:", 5450, 16, true);
            WriteAttributeValue(" ", 5465, "fadeInLeft;", 5466, 12, true);
            EndWriteAttribute();
            BeginContext(5478, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(5601, 25, false);
#line 101 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherSkill.Design);

#line default
#line hidden
            EndContext();
            BeginContext(5626, 468, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6094, "\"", 6239, 11);
            WriteAttributeValue("", 6102, "width:", 6102, 6, true);
#line 110 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 6108, Model.TeacherSkill.Innovation, 6109, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 6139, "%;", 6139, 2, true);
            WriteAttributeValue(" ", 6141, "visibility:", 6142, 12, true);
            WriteAttributeValue(" ", 6153, "visible;", 6154, 9, true);
            WriteAttributeValue(" ", 6162, "animation-duration:", 6163, 20, true);
            WriteAttributeValue(" ", 6182, "1.5s;", 6183, 6, true);
            WriteAttributeValue(" ", 6188, "animation-delay:", 6189, 17, true);
            WriteAttributeValue(" ", 6205, "1.2s;", 6206, 6, true);
            WriteAttributeValue(" ", 6211, "animation-name:", 6212, 16, true);
            WriteAttributeValue(" ", 6227, "fadeInLeft;", 6228, 12, true);
            EndWriteAttribute();
            BeginContext(6240, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(6363, 29, false);
#line 111 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherSkill.Innovation);

#line default
#line hidden
            EndContext();
            BeginContext(6392, 471, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6863, "\"", 7011, 11);
            WriteAttributeValue("", 6871, "width:", 6871, 6, true);
#line 120 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 6877, Model.TeacherSkill.Communication, 6878, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 6911, "%;", 6911, 2, true);
            WriteAttributeValue(" ", 6913, "visibility:", 6914, 12, true);
            WriteAttributeValue(" ", 6925, "visible;", 6926, 9, true);
            WriteAttributeValue(" ", 6934, "animation-duration:", 6935, 20, true);
            WriteAttributeValue(" ", 6954, "1.5s;", 6955, 6, true);
            WriteAttributeValue(" ", 6960, "animation-delay:", 6961, 17, true);
            WriteAttributeValue(" ", 6977, "1.2s;", 6978, 6, true);
            WriteAttributeValue(" ", 6983, "animation-name:", 6984, 16, true);
            WriteAttributeValue(" ", 6999, "fadeInLeft;", 7000, 12, true);
            EndWriteAttribute();
            BeginContext(7012, 122, true);
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
            EndContext();
            BeginContext(7135, 32, false);
#line 121 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.TeacherSkill.Communication);

#line default
#line hidden
            EndContext();
            BeginContext(7167, 292, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->
");
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

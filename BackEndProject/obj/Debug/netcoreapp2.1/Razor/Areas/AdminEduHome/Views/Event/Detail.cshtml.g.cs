#pragma checksum "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d573ee794c1da1f2aca6eab54977d3d7b4b7b2d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminEduHome_Views_Event_Detail), @"mvc.1.0.view", @"/Areas/AdminEduHome/Views/Event/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminEduHome/Views/Event/Detail.cshtml", typeof(AspNetCore.Areas_AdminEduHome_Views_Event_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d573ee794c1da1f2aca6eab54977d3d7b4b7b2d6", @"/Areas/AdminEduHome/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de08ed6ded2e8843ca2fb56921055337c5d2ba4", @"/Areas/AdminEduHome/Views/_ViewImports.cshtml")]
    public class Areas_AdminEduHome_Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
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
#line 2 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
  
	ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(53, 33, true);
            WriteLiteral("\r\n<div>\r\n\t<h4>Event Image</h4>\r\n\t");
            EndContext();
            BeginContext(86, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c622d7172f79464e93ff640b413c094e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 96, "~/img/event/", 96, 12, true);
#line 8 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 108, Model.ImagePath, 108, 16, false);

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
            BeginContext(161, 68, true);
            WriteLiteral("\r\n</div>\r\n<div style=\"margin-top:40px\">\r\n\t<h4>Event title</h4>\r\n\t<p>");
            EndContext();
            BeginContext(230, 11, false);
#line 12 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
  Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(241, 78, true);
            WriteLiteral("</p>\r\n</div>\r\n<div style=\"margin-top:40px\">\r\n\t<h4>Event description</h4>\r\n\t<p>");
            EndContext();
            BeginContext(320, 27, false);
#line 16 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
  Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(347, 116, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"row justify-content-around\" style=\"margin-top:40px\">\r\n\t<div>\r\n\t\t<h4>Date event</h4>\r\n\t\t<p>");
            EndContext();
            BeginContext(464, 10, false);
#line 21 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
      Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(474, 51, true);
            WriteLiteral("</p>\r\n\t</div>\r\n\t<div>\r\n\t\t<h4>Time event</h4>\r\n\t\t<p>");
            EndContext();
            BeginContext(526, 10, false);
#line 25 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
      Write(Model.Time);

#line default
#line hidden
            EndContext();
            BeginContext(536, 46, true);
            WriteLiteral("</p>\r\n\t</div>\r\n\t<div>\r\n\t\t<h4>Venue</h4>\r\n\t\t<p>");
            EndContext();
            BeginContext(583, 11, false);
#line 29 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
      Write(Model.Venue);

#line default
#line hidden
            EndContext();
            BeginContext(594, 80, true);
            WriteLiteral("</p>\r\n\t</div>\r\n</div>\r\n<div style=\"margin-top:40px\">\r\n\t<h4>Event speakers</h4>\r\n");
            EndContext();
#line 34 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
     foreach (EventSpeaker eventSpeaker in Model.EventSpeakers)
	{

#line default
#line hidden
            BeginContext(740, 59, true);
            WriteLiteral("\t\t<div class=\"row\" style=\"margin-top:15px\">\r\n\t\t\t<div>\r\n\t\t\t\t");
            EndContext();
            BeginContext(799, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6245321a134641fab07ddecc86ef2315", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 809, "~/img/event/", 809, 12, true);
#line 38 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 821, eventSpeaker.Speaker.ImagePath, 821, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(856, 71, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div style=\"margin-left:10px;margin-top:15px\">\r\n\t\t\t\t<p>");
            EndContext();
            BeginContext(928, 29, false);
#line 41 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
              Write(eventSpeaker.Speaker.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(957, 13, true);
            WriteLiteral("</p>\r\n\t\t\t\t<p>");
            EndContext();
            BeginContext(971, 31, false);
#line 42 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
              Write(eventSpeaker.Speaker.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 27, true);
            WriteLiteral("</p>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            EndContext();
#line 45 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Detail.cshtml"
	}

#line default
#line hidden
            BeginContext(1033, 52, true);
            WriteLiteral("</div>\r\n<div class=\"row\" style=\"margin-top:20px\">\r\n\t");
            EndContext();
            BeginContext(1085, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "655f78a26bf640c88cb0aa60cb8f6c50", async() => {
                BeginContext(1128, 7, true);
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
            BeginContext(1139, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
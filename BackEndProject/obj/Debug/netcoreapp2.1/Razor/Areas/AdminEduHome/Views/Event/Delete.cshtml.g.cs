#pragma checksum "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2082660e8f642284173e7a4138086e704b91864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminEduHome_Views_Event_Delete), @"mvc.1.0.view", @"/Areas/AdminEduHome/Views/Event/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminEduHome/Views/Event/Delete.cshtml", typeof(AspNetCore.Areas_AdminEduHome_Views_Event_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2082660e8f642284173e7a4138086e704b91864", @"/Areas/AdminEduHome/Views/Event/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de08ed6ded2e8843ca2fb56921055337c5d2ba4", @"/Areas/AdminEduHome/Views/_ViewImports.cshtml")]
    public class Areas_AdminEduHome_Views_Event_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("450"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
  
	ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(55, 1153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cd1a0930fb54e3492622c4e400abfcb", async() => {
                BeginContext(85, 36, true);
                WriteLiteral("\r\n\t<div>\r\n\t\t<h4>Event Image</h4>\r\n\t\t");
                EndContext();
                BeginContext(121, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ea7c055326a44f1a2f4563947570f7f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 131, "~/img/event/", 131, 12, true);
#line 9 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
AddHtmlAttributeValue("", 143, Model.ImagePath, 143, 16, false);

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
                BeginContext(196, 72, true);
                WriteLiteral("\r\n\t</div>\r\n\t<div style=\"margin-top:40px\">\r\n\t\t<h4>Event title</h4>\r\n\t\t<p>");
                EndContext();
                BeginContext(269, 11, false);
#line 13 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
      Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(280, 82, true);
                WriteLiteral("</p>\r\n\t</div>\r\n\t<div style=\"margin-top:40px\">\r\n\t\t<h4>Event description</h4>\r\n\t\t<p>");
                EndContext();
                BeginContext(363, 27, false);
#line 17 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
      Write(Html.Raw(Model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(390, 121, true);
                WriteLiteral("</p>\r\n\t</div>\r\n\t<div class=\"row justify-content-around\" style=\"margin-top:40px\">\r\n\t\t<div>\r\n\t\t\t<h4>Date event</h4>\r\n\t\t\t<p>");
                EndContext();
                BeginContext(512, 10, false);
#line 22 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
          Write(Model.Date);

#line default
#line hidden
                EndContext();
                BeginContext(522, 55, true);
                WriteLiteral("</p>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<h4>Time event</h4>\r\n\t\t\t<p>");
                EndContext();
                BeginContext(578, 10, false);
#line 26 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
          Write(Model.Time);

#line default
#line hidden
                EndContext();
                BeginContext(588, 50, true);
                WriteLiteral("</p>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<h4>Venue</h4>\r\n\t\t\t<p>");
                EndContext();
                BeginContext(639, 11, false);
#line 30 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
          Write(Model.Venue);

#line default
#line hidden
                EndContext();
                BeginContext(650, 84, true);
                WriteLiteral("</p>\r\n\t\t</div>\r\n\t</div>\r\n\t<div style=\"margin-top:40px\">\r\n\t\t<h4>Event speakers</h4>\r\n");
                EndContext();
#line 35 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
         foreach (EventSpeaker eventSpeaker in Model.EventSpeakers)
		{

#line default
#line hidden
                BeginContext(802, 62, true);
                WriteLiteral("\t\t\t<div class=\"row\" style=\"margin-top:15px\">\r\n\t\t\t\t<div>\r\n\t\t\t\t\t");
                EndContext();
                BeginContext(864, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a440c979195479f8b295d4e748e334e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 874, "~/img/event/", 874, 12, true);
#line 39 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
AddHtmlAttributeValue("", 886, eventSpeaker.Speaker.ImagePath, 886, 31, false);

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
                BeginContext(921, 74, true);
                WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div style=\"margin-left:10px;margin-top:15px\">\r\n\t\t\t\t\t<p>");
                EndContext();
                BeginContext(996, 29, false);
#line 42 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
                  Write(eventSpeaker.Speaker.Fullname);

#line default
#line hidden
                EndContext();
                BeginContext(1025, 14, true);
                WriteLiteral("</p>\r\n\t\t\t\t\t<p>");
                EndContext();
                BeginContext(1040, 31, false);
#line 43 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
                  Write(eventSpeaker.Speaker.Profession);

#line default
#line hidden
                EndContext();
                BeginContext(1071, 29, true);
                WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
                EndContext();
#line 46 "C:\Users\nijat\source\repos\BackEndProject\BackEndProject\Areas\AdminEduHome\Views\Event\Delete.cshtml"
		}

#line default
#line hidden
                BeginContext(1105, 96, true);
                WriteLiteral("\t</div>\r\n\t<button style=\"margin-top:20px\" type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n");
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
            BeginContext(1208, 46, true);
            WriteLiteral("\r\n<div class=\"row\" style=\"margin-top:20px\">\r\n\t");
            EndContext();
            BeginContext(1254, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2baaccd2c4d241959d8b81dee529cc79", async() => {
                BeginContext(1297, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1308, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1335, 656, true);
                WriteLiteral(@"
	<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
	<script>
		$(""#form"").submit(function (e) {
			e.preventDefault();
			swal({
				title: ""Are you sure?"",
				text: ""Once deleted, you will not be able to recover this file!"",
				icon: ""warning"",
				buttons: true,
				dangerMode: true,
			})
				.then((willDelete) => {
					if (willDelete) {
						swal(""Event has been deleted!"", {
							icon: ""success"",
						}).then(function () {
							setTimeout(() => document.querySelector(""#form"").submit(), 100);
						})
					} else {
						swal(""Event was not deleted!"");
					}
				});

		})
	</script>
");
                EndContext();
            }
            );
            BeginContext(1994, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591

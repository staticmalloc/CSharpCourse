#pragma checksum "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request7.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac3316a7b6941029d93a042e09f60e98ef8aad4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Request7), @"mvc.1.0.view", @"/Views/Main/Request7.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Request7.cshtml", typeof(AspNetCore.Views_Main_Request7))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac3316a7b6941029d93a042e09f60e98ef8aad4", @"/Views/Main/Request7.cshtml")]
    public class Views_Main_Request7 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityDataBase.Views.Main.Request7>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(74, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac3316a7b6941029d93a042e09f60e98ef8aad42953", async() => {
                BeginContext(80, 60, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Request 7</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(149, 831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac3316a7b6941029d93a042e09f60e98ef8aad44198", async() => {
                BeginContext(155, 31, true);
                WriteLiteral("\r\n<h3>Request 7</h3>\r\n\r\n<div>\r\n");
                EndContext();
#line 13 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request7.cshtml"
     using (Html.BeginForm("Req7", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(255, 83, true);
                WriteLiteral("        <div class=\"form\">\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(339, 54, false);
#line 17 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request7.cshtml"
           Write(Html.LabelFor(model => model.Discipline, "Discipline"));

#line default
#line hidden
                EndContext();
                BeginContext(393, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(459, 82, false);
#line 19 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request7.cshtml"
               Write(Html.DropDownListFor(model => model.Discipline, ViewBag.disciplines as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(541, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(643, 42, false);
#line 23 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request7.cshtml"
           Write(Html.LabelFor(model => model.Mark, "Mark"));

#line default
#line hidden
                EndContext();
                BeginContext(685, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(751, 70, false);
#line 25 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request7.cshtml"
               Write(Html.DropDownListFor(model => model.Mark, ViewBag.marks as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(821, 135, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\"/>\r\n        </div>\r\n");
                EndContext();
#line 31 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request7.cshtml"
    }

#line default
#line hidden
                BeginContext(963, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(980, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityDataBase.Views.Main.Request7> Html { get; private set; }
    }
}
#pragma warning restore 1591
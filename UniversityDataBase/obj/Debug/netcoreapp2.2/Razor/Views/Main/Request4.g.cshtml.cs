#pragma checksum "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00fbb33c98394028448ea97a129357d1e4731af9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Request4), @"mvc.1.0.view", @"/Views/Main/Request4.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Request4.cshtml", typeof(AspNetCore.Views_Main_Request4))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00fbb33c98394028448ea97a129357d1e4731af9", @"/Views/Main/Request4.cshtml")]
    public class Views_Main_Request4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityDataBase.Views.Main.Request4>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00fbb33c98394028448ea97a129357d1e4731af92953", async() => {
                BeginContext(80, 60, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Request 4</title>\r\n");
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
            BeginContext(149, 2448, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00fbb33c98394028448ea97a129357d1e4731af94199", async() => {
                BeginContext(155, 61, true);
                WriteLiteral("\r\n<h3>Request 4</h3>\r\n\r\n<div>\r\n    <h4>By Group Number</h4>\r\n");
                EndContext();
#line 14 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
     using (Html.BeginForm("Req4_1", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(287, 86, true);
                WriteLiteral("        <div class=\"form\">\r\n \r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(374, 58, false);
#line 19 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
           Write(Html.LabelFor(model => model.Group, "The number of group"));

#line default
#line hidden
                EndContext();
                BeginContext(432, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(498, 72, false);
#line 21 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
               Write(Html.DropDownListFor(model => model.Group, ViewBag.groups as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(570, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        \r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\" />\r\n        </div>\r\n");
                EndContext();
#line 27 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
    }

#line default
#line hidden
                BeginContext(721, 46, true);
                WriteLiteral("    <h4>By Faculty, course and semester</h4>\r\n");
                EndContext();
#line 29 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
     using (Html.BeginForm("Req4_2", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(838, 85, true);
                WriteLiteral("        <div class=\"form\">\r\n\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(924, 48, false);
#line 34 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
           Write(Html.LabelFor(model => model.Faculty, "Faculty"));

#line default
#line hidden
                EndContext();
                BeginContext(972, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1038, 77, false);
#line 36 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
               Write(Html.DropDownListFor(model => model.Faculty, ViewBag.faculties as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1115, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(1217, 46, false);
#line 40 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
           Write(Html.LabelFor(model => model.Course, "Course"));

#line default
#line hidden
                EndContext();
                BeginContext(1263, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1329, 74, false);
#line 42 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
               Write(Html.DropDownListFor(model => model.Course, ViewBag.courses as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1403, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(1505, 50, false);
#line 46 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
           Write(Html.LabelFor(model => model.Semester, "Semester"));

#line default
#line hidden
                EndContext();
                BeginContext(1555, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1621, 78, false);
#line 48 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
               Write(Html.DropDownListFor(model => model.Semester, ViewBag.semesters as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1699, 135, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\"/>\r\n        </div>\r\n");
                EndContext();
#line 54 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
    }

#line default
#line hidden
                BeginContext(1841, 24, true);
                WriteLiteral("    <h4>By Period</h4>\r\n");
                EndContext();
#line 56 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
     using (Html.BeginForm("Req4_3", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(1936, 86, true);
                WriteLiteral("        <div class=\"form\">\r\n \r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(2023, 54, false);
#line 61 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
           Write(Html.LabelFor(model => model.Begin, "Begin of period"));

#line default
#line hidden
                EndContext();
                BeginContext(2077, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(2143, 36, false);
#line 63 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
               Write(Html.EditorFor(model => model.Begin));

#line default
#line hidden
                EndContext();
                BeginContext(2179, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(2281, 50, false);
#line 67 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
           Write(Html.LabelFor(model => model.End, "End of period"));

#line default
#line hidden
                EndContext();
                BeginContext(2331, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(2397, 34, false);
#line 69 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
               Write(Html.EditorFor(model => model.End));

#line default
#line hidden
                EndContext();
                BeginContext(2431, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        \r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\" />\r\n        </div>\r\n");
                EndContext();
#line 75 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request4.cshtml"
    }

#line default
#line hidden
                BeginContext(2582, 8, true);
                WriteLiteral("</div>\r\n");
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
            BeginContext(2597, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityDataBase.Views.Main.Request4> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b49147e0526a8f5c3978f690f2d4afb511bc5f61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Request6), @"mvc.1.0.view", @"/Views/Main/Request6.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Request6.cshtml", typeof(AspNetCore.Views_Main_Request6))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b49147e0526a8f5c3978f690f2d4afb511bc5f61", @"/Views/Main/Request6.cshtml")]
    public class Views_Main_Request6 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityDataBase.Views.Main.Request6>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b49147e0526a8f5c3978f690f2d4afb511bc5f612934", async() => {
                BeginContext(80, 60, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Request 6</title>\r\n");
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
            BeginContext(149, 3283, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b49147e0526a8f5c3978f690f2d4afb511bc5f614180", async() => {
                BeginContext(155, 67, true);
                WriteLiteral("\r\n<h3>Request 6</h3>\r\n\r\n<div>\r\n    \r\n    <h4>By Group Number</h4>\r\n");
                EndContext();
#line 15 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
     using (Html.BeginForm("Req6_1", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(293, 83, true);
                WriteLiteral("        <div class=\"form\">\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(377, 43, false);
#line 19 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
           Write(Html.LabelFor(model => model.Type1, "Type"));

#line default
#line hidden
                EndContext();
                BeginContext(420, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(486, 71, false);
#line 21 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
               Write(Html.DropDownListFor(model => model.Type1, ViewBag.types as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(557, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(659, 58, false);
#line 25 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
           Write(Html.LabelFor(model => model.Group, "The number of group"));

#line default
#line hidden
                EndContext();
                BeginContext(717, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(783, 72, false);
#line 27 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
               Write(Html.DropDownListFor(model => model.Group, ViewBag.groups as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(855, 135, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\"/>\r\n        </div>\r\n");
                EndContext();
#line 33 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
    }

#line default
#line hidden
                BeginContext(997, 46, true);
                WriteLiteral("    <h4>By Faculty, course and semester</h4>\r\n");
                EndContext();
#line 35 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
     using (Html.BeginForm("Req6_2", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(1114, 83, true);
                WriteLiteral("        <div class=\"form\">\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(1198, 43, false);
#line 39 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
           Write(Html.LabelFor(model => model.Type2, "Type"));

#line default
#line hidden
                EndContext();
                BeginContext(1241, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1307, 71, false);
#line 41 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
               Write(Html.DropDownListFor(model => model.Type2, ViewBag.types as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1378, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(1480, 48, false);
#line 45 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
           Write(Html.LabelFor(model => model.Faculty, "Faculty"));

#line default
#line hidden
                EndContext();
                BeginContext(1528, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1594, 77, false);
#line 47 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
               Write(Html.DropDownListFor(model => model.Faculty, ViewBag.faculties as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1671, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(1773, 46, false);
#line 51 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
           Write(Html.LabelFor(model => model.Course, "Course"));

#line default
#line hidden
                EndContext();
                BeginContext(1819, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1885, 74, false);
#line 53 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
               Write(Html.DropDownListFor(model => model.Course, ViewBag.courses as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1959, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(2061, 50, false);
#line 57 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
           Write(Html.LabelFor(model => model.Semester, "Semester"));

#line default
#line hidden
                EndContext();
                BeginContext(2111, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(2177, 78, false);
#line 59 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
               Write(Html.DropDownListFor(model => model.Semester, ViewBag.semesters as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(2255, 135, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\"/>\r\n        </div>\r\n");
                EndContext();
#line 65 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
    }

#line default
#line hidden
                BeginContext(2397, 24, true);
                WriteLiteral("    <h4>By Period</h4>\r\n");
                EndContext();
#line 67 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
     using (Html.BeginForm("Req6_3", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(2492, 83, true);
                WriteLiteral("        <div class=\"form\">\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(2576, 43, false);
#line 71 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
           Write(Html.LabelFor(model => model.Type3, "Type"));

#line default
#line hidden
                EndContext();
                BeginContext(2619, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(2685, 71, false);
#line 73 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
               Write(Html.DropDownListFor(model => model.Type3, ViewBag.types as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(2756, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(2858, 54, false);
#line 77 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
           Write(Html.LabelFor(model => model.Begin, "Begin of period"));

#line default
#line hidden
                EndContext();
                BeginContext(2912, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(2978, 36, false);
#line 79 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
               Write(Html.EditorFor(model => model.Begin));

#line default
#line hidden
                EndContext();
                BeginContext(3014, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(3116, 50, false);
#line 83 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
           Write(Html.LabelFor(model => model.End, "End of period"));

#line default
#line hidden
                EndContext();
                BeginContext(3166, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(3232, 34, false);
#line 85 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
               Write(Html.EditorFor(model => model.End));

#line default
#line hidden
                EndContext();
                BeginContext(3266, 144, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        \r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\" />\r\n        </div>\r\n");
                EndContext();
#line 91 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request6.cshtml"
    }

#line default
#line hidden
                BeginContext(3417, 8, true);
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
            BeginContext(3432, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityDataBase.Views.Main.Request6> Html { get; private set; }
    }
}
#pragma warning restore 1591

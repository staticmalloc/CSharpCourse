#pragma checksum "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f840be77aac2927bbd6e233513773b2040094ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Request8), @"mvc.1.0.view", @"/Views/Main/Request8.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Request8.cshtml", typeof(AspNetCore.Views_Main_Request8))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f840be77aac2927bbd6e233513773b2040094ec", @"/Views/Main/Request8.cshtml")]
    public class Views_Main_Request8 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityDataBase.Views.Main.Request8>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f840be77aac2927bbd6e233513773b2040094ec2953", async() => {
                BeginContext(80, 60, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Request 8</title>\r\n");
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
            BeginContext(149, 2553, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f840be77aac2927bbd6e233513773b2040094ec4199", async() => {
                BeginContext(155, 63, true);
                WriteLiteral("\r\n<h3>Request 8</h3>\r\n\r\n<div>\r\n\r\n    <h4>By Group Number</h4>\r\n");
                EndContext();
#line 15 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
     using (Html.BeginForm("Req8_1", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(289, 83, true);
                WriteLiteral("        <div class=\"form\">\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(373, 49, false);
#line 19 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
           Write(Html.LabelFor(model => model.Session1, "Session"));

#line default
#line hidden
                EndContext();
                BeginContext(422, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(488, 77, false);
#line 21 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
               Write(Html.DropDownListFor(model => model.Session1, ViewBag.sessions as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(565, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(667, 51, false);
#line 25 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
           Write(Html.LabelFor(model => model.Mark1, "Minimum mark"));

#line default
#line hidden
                EndContext();
                BeginContext(718, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(784, 71, false);
#line 27 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
               Write(Html.DropDownListFor(model => model.Mark1, ViewBag.marks as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(855, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(957, 58, false);
#line 31 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
           Write(Html.LabelFor(model => model.Group, "The number of group"));

#line default
#line hidden
                EndContext();
                BeginContext(1015, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1081, 72, false);
#line 33 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
               Write(Html.DropDownListFor(model => model.Group, ViewBag.groups as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1153, 133, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\"/>\r\n        </div>\r\n");
                EndContext();
#line 38 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
    }

#line default
#line hidden
                BeginContext(1293, 36, true);
                WriteLiteral("    <h4>By Faculty and course</h4>\r\n");
                EndContext();
#line 40 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
     using (Html.BeginForm("Req8_2", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(1400, 83, true);
                WriteLiteral("        <div class=\"form\">\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(1484, 49, false);
#line 44 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
           Write(Html.LabelFor(model => model.Session2, "Session"));

#line default
#line hidden
                EndContext();
                BeginContext(1533, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1599, 77, false);
#line 46 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
               Write(Html.DropDownListFor(model => model.Session2, ViewBag.sessions as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1676, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(1778, 51, false);
#line 50 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
           Write(Html.LabelFor(model => model.Mark2, "Minimum mark"));

#line default
#line hidden
                EndContext();
                BeginContext(1829, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1895, 71, false);
#line 52 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
               Write(Html.DropDownListFor(model => model.Mark2, ViewBag.marks as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1966, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(2068, 48, false);
#line 56 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
           Write(Html.LabelFor(model => model.Faculty, "Faculty"));

#line default
#line hidden
                EndContext();
                BeginContext(2116, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(2182, 77, false);
#line 58 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
               Write(Html.DropDownListFor(model => model.Faculty, ViewBag.faculties as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(2259, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(2361, 46, false);
#line 62 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
           Write(Html.LabelFor(model => model.Course, "Course"));

#line default
#line hidden
                EndContext();
                BeginContext(2407, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(2473, 74, false);
#line 64 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
               Write(Html.DropDownListFor(model => model.Course, ViewBag.courses as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(2547, 133, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\"/>\r\n        </div>\r\n");
                EndContext();
#line 69 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Request8.cshtml"
    }

#line default
#line hidden
                BeginContext(2687, 8, true);
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
            BeginContext(2702, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityDataBase.Views.Main.Request8> Html { get; private set; }
    }
}
#pragma warning restore 1591
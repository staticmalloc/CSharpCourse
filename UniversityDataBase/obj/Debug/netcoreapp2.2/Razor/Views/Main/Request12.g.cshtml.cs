#pragma checksum "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d097a29b0ff324171eee5a9f7218b578441783d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Request12), @"mvc.1.0.view", @"/Views/Main/Request12.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Request12.cshtml", typeof(AspNetCore.Views_Main_Request12))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d097a29b0ff324171eee5a9f7218b578441783d1", @"/Views/Main/Request12.cshtml")]
    public class Views_Main_Request12 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityDataBase.Views.Main.Request12>
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
            BeginContext(48, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(75, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d097a29b0ff324171eee5a9f7218b578441783d12942", async() => {
                BeginContext(81, 61, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Request 12</title>\r\n");
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
            BeginContext(149, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(151, 1692, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d097a29b0ff324171eee5a9f7218b578441783d14189", async() => {
                BeginContext(157, 57, true);
                WriteLiteral("\r\n<h3>Request 12</h3>\r\n\r\n<div>\r\n    <h4>By Cafedra</h4>\r\n");
                EndContext();
#line 14 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
     using (Html.BeginForm("Req12_1", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(286, 86, true);
                WriteLiteral("        <div class=\"form\">\r\n \r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(373, 60, false);
#line 19 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
           Write(Html.LabelFor(model => model.Cafedra, "The number of group"));

#line default
#line hidden
                EndContext();
                BeginContext(433, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(499, 76, false);
#line 21 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
               Write(Html.DropDownListFor(model => model.Cafedra, ViewBag.cafedras as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(575, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(677, 51, false);
#line 25 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
           Write(Html.LabelFor(model => model.Category1, "Category"));

#line default
#line hidden
                EndContext();
                BeginContext(728, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(794, 80, false);
#line 27 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
               Write(Html.DropDownListFor(model => model.Category1, ViewBag.categories as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(874, 134, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\" />\r\n        </div>\r\n");
                EndContext();
#line 32 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
    }

#line default
#line hidden
                BeginContext(1015, 25, true);
                WriteLiteral("    <h4>By Faculty</h4>\r\n");
                EndContext();
#line 34 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
     using (Html.BeginForm("Req12_2", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(1112, 85, true);
                WriteLiteral("        <div class=\"form\">\r\n\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(1198, 49, false);
#line 39 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
           Write(Html.LabelFor(model => model.Faculty, "Category"));

#line default
#line hidden
                EndContext();
                BeginContext(1247, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1313, 77, false);
#line 41 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
               Write(Html.DropDownListFor(model => model.Faculty, ViewBag.faculties as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1390, 101, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(1492, 50, false);
#line 45 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
           Write(Html.LabelFor(model => model.Category2, "Faculty"));

#line default
#line hidden
                EndContext();
                BeginContext(1542, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1608, 80, false);
#line 47 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
               Write(Html.DropDownListFor(model => model.Category2, ViewBag.categories as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1688, 133, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\"/>\r\n        </div>\r\n");
                EndContext();
#line 52 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request12.cshtml"
    }

#line default
#line hidden
                BeginContext(1828, 8, true);
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
            BeginContext(1843, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityDataBase.Views.Main.Request12> Html { get; private set; }
    }
}
#pragma warning restore 1591

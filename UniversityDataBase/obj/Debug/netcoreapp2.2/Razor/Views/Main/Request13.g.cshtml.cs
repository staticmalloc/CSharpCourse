#pragma checksum "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request13.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80a0989f863baa519fe2438749188fda89a728c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Request13), @"mvc.1.0.view", @"/Views/Main/Request13.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Request13.cshtml", typeof(AspNetCore.Views_Main_Request13))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a0989f863baa519fe2438749188fda89a728c0", @"/Views/Main/Request13.cshtml")]
    public class Views_Main_Request13 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityDataBase.Views.Main.Request13>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a0989f863baa519fe2438749188fda89a728c02942", async() => {
                BeginContext(81, 61, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Request 13</title>\r\n");
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
            BeginContext(151, 1107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a0989f863baa519fe2438749188fda89a728c04189", async() => {
                BeginContext(157, 57, true);
                WriteLiteral("\r\n<h3>Request 13</h3>\r\n\r\n<div>\r\n    <h4>By Teacher</h4>\r\n");
                EndContext();
#line 14 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request13.cshtml"
     using (Html.BeginForm("Req13_1", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(286, 86, true);
                WriteLiteral("        <div class=\"form\">\r\n \r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(373, 60, false);
#line 19 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request13.cshtml"
           Write(Html.LabelFor(model => model.Teacher, "The number of group"));

#line default
#line hidden
                EndContext();
                BeginContext(433, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(499, 76, false);
#line 21 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request13.cshtml"
               Write(Html.DropDownListFor(model => model.Teacher, ViewBag.teachers as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(575, 134, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\" />\r\n        </div>\r\n");
                EndContext();
#line 26 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request13.cshtml"
    }

#line default
#line hidden
                BeginContext(716, 25, true);
                WriteLiteral("    <h4>By Cafedra</h4>\r\n");
                EndContext();
#line 28 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request13.cshtml"
     using (Html.BeginForm("Req13_2", "Main", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(813, 86, true);
                WriteLiteral("        <div class=\"form\">\r\n \r\n            <div class=\"input_group\">\r\n                ");
                EndContext();
                BeginContext(900, 60, false);
#line 33 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request13.cshtml"
           Write(Html.LabelFor(model => model.Cafedra, "The number of group"));

#line default
#line hidden
                EndContext();
                BeginContext(960, 65, true);
                WriteLiteral("\r\n                <div class=\"input_field\">\r\n                    ");
                EndContext();
                BeginContext(1026, 76, false);
#line 35 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request13.cshtml"
               Write(Html.DropDownListFor(model => model.Cafedra, ViewBag.cafedras as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1102, 134, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <input class=\"main_button\" type=\"submit\" value=\"Select\" />\r\n        </div>\r\n");
                EndContext();
#line 40 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request13.cshtml"
    }

#line default
#line hidden
                BeginContext(1243, 8, true);
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
            BeginContext(1258, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityDataBase.Views.Main.Request13> Html { get; private set; }
    }
}
#pragma warning restore 1591

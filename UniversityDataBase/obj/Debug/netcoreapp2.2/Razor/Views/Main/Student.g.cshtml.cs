#pragma checksum "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa5ff60b190c5d6b15e4ac4c150806cec22fa95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Student), @"mvc.1.0.view", @"/Views/Main/Student.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Student.cshtml", typeof(AspNetCore.Views_Main_Student))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaa5ff60b190c5d6b15e4ac4c150806cec22fa95", @"/Views/Main/Student.cshtml")]
    public class Views_Main_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityDataBase.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(71, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaa5ff60b190c5d6b15e4ac4c150806cec22fa954133", async() => {
                BeginContext(77, 38, true);
                WriteLiteral("\r\n    <title>Add Student</title>\r\n    ");
                EndContext();
                BeginContext(115, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eaa5ff60b190c5d6b15e4ac4c150806cec22fa954552", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(178, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(187, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 2006, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaa5ff60b190c5d6b15e4ac4c150806cec22fa956768", async() => {
                BeginContext(195, 24, true);
                WriteLiteral("\r\n<h3>Add Student</h3>\r\n");
                EndContext();
#line 12 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
 using (Html.BeginForm("UpdateStudent", "Main", FormMethod.Post))
{

#line default
#line hidden
                BeginContext(289, 32, true);
                WriteLiteral("    <div class=\"form\">\r\n        ");
                EndContext();
                BeginContext(322, 33, false);
#line 15 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(355, 49, true);
                WriteLiteral("\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(405, 47, false);
#line 17 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
       Write(Html.LabelFor(model => model.Name, "Full Name"));

#line default
#line hidden
                EndContext();
                BeginContext(452, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(510, 35, false);
#line 19 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
           Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(545, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(631, 48, false);
#line 23 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
       Write(Html.LabelFor(model => model.Sex, "Sex(f or m)"));

#line default
#line hidden
                EndContext();
                BeginContext(679, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(737, 34, false);
#line 25 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
           Write(Html.EditorFor(model => model.Sex));

#line default
#line hidden
                EndContext();
                BeginContext(771, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(857, 52, false);
#line 29 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
       Write(Html.LabelFor(model => model.Birth, "Date of Birth"));

#line default
#line hidden
                EndContext();
                BeginContext(909, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(967, 36, false);
#line 31 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
           Write(Html.EditorFor(model => model.Birth));

#line default
#line hidden
                EndContext();
                BeginContext(1003, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(1089, 40, false);
#line 35 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
       Write(Html.LabelFor(model => model.Age, "Age"));

#line default
#line hidden
                EndContext();
                BeginContext(1129, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(1187, 34, false);
#line 37 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
           Write(Html.EditorFor(model => model.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1221, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(1307, 45, false);
#line 41 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
       Write(Html.LabelFor(model => model.Child, "Childs"));

#line default
#line hidden
                EndContext();
                BeginContext(1352, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(1410, 36, false);
#line 43 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
           Write(Html.EditorFor(model => model.Child));

#line default
#line hidden
                EndContext();
                BeginContext(1446, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(1532, 44, false);
#line 47 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
       Write(Html.LabelFor(model => model.Award, "Award"));

#line default
#line hidden
                EndContext();
                BeginContext(1576, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(1634, 36, false);
#line 49 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
           Write(Html.EditorFor(model => model.Award));

#line default
#line hidden
                EndContext();
                BeginContext(1670, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(1756, 61, false);
#line 53 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
       Write(Html.LabelFor(model => model.GroupNum, "The number of group"));

#line default
#line hidden
                EndContext();
                BeginContext(1817, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(1875, 75, false);
#line 55 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
           Write(Html.DropDownListFor(model => model.GroupNum, ViewBag.groups as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1950, 130, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <input class=\"main_button\" type=\"submit\" value=\"Отправить\"/>\r\n    </div>\r\n");
                EndContext();
#line 61 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
}

#line default
#line hidden
                BeginContext(2083, 27, true);
                WriteLiteral("<button class=\"main_button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2110, "\"", 2168, 5);
                WriteAttributeValue("", 2120, "document.location", 2120, 17, true);
                WriteAttributeValue(" ", 2137, "=", 2138, 2, true);
                WriteAttributeValue(" ", 2139, "\'", 2140, 2, true);
#line 62 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Student.cshtml"
WriteAttributeValue("", 2141, Url.Action("AllStudents"), 2141, 26, false);

#line default
#line hidden
                WriteAttributeValue("", 2167, "\'", 2167, 1, true);
                EndWriteAttribute();
                BeginContext(2169, 19, true);
                WriteLiteral(">Назад</button>\r\n\r\n");
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
            BeginContext(2195, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityDataBase.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591

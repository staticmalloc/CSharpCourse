#pragma checksum "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25af8efe3fef5fbe48cf665795deaac8d80f10a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Teacher), @"mvc.1.0.view", @"/Views/Main/Teacher.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Teacher.cshtml", typeof(AspNetCore.Views_Main_Teacher))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25af8efe3fef5fbe48cf665795deaac8d80f10a5", @"/Views/Main/Teacher.cshtml")]
    public class Views_Main_Teacher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityDataBase.Models.Teacher>
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
            BeginContext(71, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25af8efe3fef5fbe48cf665795deaac8d80f10a54152", async() => {
                BeginContext(77, 46, true);
                WriteLiteral("\r\n    <title>Add or Edit Teacher</title>\r\n    ");
                EndContext();
                BeginContext(123, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25af8efe3fef5fbe48cf665795deaac8d80f10a54579", async() => {
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
                BeginContext(186, 2, true);
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
            BeginContext(195, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(197, 2557, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25af8efe3fef5fbe48cf665795deaac8d80f10a56795", async() => {
                BeginContext(203, 32, true);
                WriteLiteral("\r\n<h3>Add or Edit Teacher</h3>\r\n");
                EndContext();
#line 12 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
 using (Html.BeginForm("UpdateTeacher", "Main", FormMethod.Post))
{

#line default
#line hidden
                BeginContext(305, 32, true);
                WriteLiteral("    <div class=\"form\">\r\n        ");
                EndContext();
                BeginContext(338, 33, false);
#line 15 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(371, 49, true);
                WriteLiteral("\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(421, 47, false);
#line 17 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
       Write(Html.LabelFor(model => model.Name, "Full Name"));

#line default
#line hidden
                EndContext();
                BeginContext(468, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(526, 35, false);
#line 19 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
           Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(561, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(647, 48, false);
#line 23 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
       Write(Html.LabelFor(model => model.Sex, "Sex(f or m)"));

#line default
#line hidden
                EndContext();
                BeginContext(695, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(753, 34, false);
#line 25 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
           Write(Html.EditorFor(model => model.Sex));

#line default
#line hidden
                EndContext();
                BeginContext(787, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(873, 52, false);
#line 29 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
       Write(Html.LabelFor(model => model.Birth, "Date of Birth"));

#line default
#line hidden
                EndContext();
                BeginContext(925, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(983, 36, false);
#line 31 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
           Write(Html.EditorFor(model => model.Birth));

#line default
#line hidden
                EndContext();
                BeginContext(1019, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(1105, 40, false);
#line 35 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
       Write(Html.LabelFor(model => model.Age, "Age"));

#line default
#line hidden
                EndContext();
                BeginContext(1145, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(1203, 34, false);
#line 37 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
           Write(Html.EditorFor(model => model.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1237, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(1323, 46, false);
#line 41 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
       Write(Html.LabelFor(model => model.Childs, "Childs"));

#line default
#line hidden
                EndContext();
                BeginContext(1369, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(1427, 37, false);
#line 43 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
           Write(Html.EditorFor(model => model.Childs));

#line default
#line hidden
                EndContext();
                BeginContext(1464, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(1550, 46, false);
#line 47 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
       Write(Html.LabelFor(model => model.Salary, "Salary"));

#line default
#line hidden
                EndContext();
                BeginContext(1596, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(1654, 37, false);
#line 49 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
           Write(Html.EditorFor(model => model.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(1691, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(1777, 50, false);
#line 53 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
       Write(Html.LabelFor(model => model.CafedraId, "Cafedra"));

#line default
#line hidden
                EndContext();
                BeginContext(1827, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(1885, 78, false);
#line 55 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
           Write(Html.DropDownListFor(model => model.CafedraId, ViewBag.cafedras as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(1963, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(2049, 50, false);
#line 59 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
       Write(Html.LabelFor(model => model.FacultyId, "Faculty"));

#line default
#line hidden
                EndContext();
                BeginContext(2099, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(2157, 79, false);
#line 61 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
           Write(Html.DropDownListFor(model => model.FacultyId, ViewBag.faculties as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(2236, 85, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"input_group\">\r\n            ");
                EndContext();
                BeginContext(2322, 50, false);
#line 65 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
       Write(Html.LabelFor(model => model.Category, "Category"));

#line default
#line hidden
                EndContext();
                BeginContext(2372, 57, true);
                WriteLiteral("\r\n            <div class=\"input_field\">\r\n                ");
                EndContext();
                BeginContext(2430, 79, false);
#line 67 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
           Write(Html.DropDownListFor(model => model.Category, ViewBag.categories as SelectList));

#line default
#line hidden
                EndContext();
                BeginContext(2509, 130, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        \r\n        <input class=\"main_button\" type=\"submit\" value=\"Отправить\"/>\r\n    </div>\r\n");
                EndContext();
#line 73 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
}

#line default
#line hidden
                BeginContext(2642, 27, true);
                WriteLiteral("<button class=\"main_button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2669, "\"", 2727, 5);
                WriteAttributeValue("", 2679, "document.location", 2679, 17, true);
                WriteAttributeValue(" ", 2696, "=", 2697, 2, true);
                WriteAttributeValue(" ", 2698, "\'", 2699, 2, true);
#line 74 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\Teacher.cshtml"
WriteAttributeValue("", 2700, Url.Action("AllTeachers"), 2700, 26, false);

#line default
#line hidden
                WriteAttributeValue("", 2726, "\'", 2726, 1, true);
                EndWriteAttribute();
                BeginContext(2728, 19, true);
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
            BeginContext(2754, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityDataBase.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
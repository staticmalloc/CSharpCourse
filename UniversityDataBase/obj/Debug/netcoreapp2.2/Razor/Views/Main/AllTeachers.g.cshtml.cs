#pragma checksum "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2bce6eae09b0b09d6300e857418b0e319fc6f0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_AllTeachers), @"mvc.1.0.view", @"/Views/Main/AllTeachers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/AllTeachers.cshtml", typeof(AspNetCore.Views_Main_AllTeachers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bce6eae09b0b09d6300e857418b0e319fc6f0c", @"/Views/Main/AllTeachers.cshtml")]
    public class Views_Main_AllTeachers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<UniversityDataBase.Models.Teacher>>
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
            BeginContext(49, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(78, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2bce6eae09b0b09d6300e857418b0e319fc6f0c4187", async() => {
                BeginContext(84, 53, true);
                WriteLiteral("\r\n    <title>All Teachers in University</title>\r\n    ");
                EndContext();
                BeginContext(137, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a2bce6eae09b0b09d6300e857418b0e319fc6f0c4621", async() => {
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
                BeginContext(200, 2, true);
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
            BeginContext(209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(211, 1526, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2bce6eae09b0b09d6300e857418b0e319fc6f0c6837", async() => {
                BeginContext(217, 411, true);
                WriteLiteral(@"
<h3>All teachers table</h3>
<div>
    <table class=""main_table"">
        <thead>
        <tr>
            <th>ID</th>
            <th>Full Name</th>
            <th>Sex</th>
            <th>BirthDate</th>
            <th>Age</th>
            <th>Childs</th>
            <th>Salary</th>
            <th>Category</th>
            <th>Actions</th>
        </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 28 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(677, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(738, 33, false);
#line 32 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
               Write(Html.DisplayFor(model => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(771, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(839, 35, false);
#line 35 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
               Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(874, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(942, 34, false);
#line 38 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
               Write(Html.DisplayFor(model => item.Sex));

#line default
#line hidden
                EndContext();
                BeginContext(976, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1044, 36, false);
#line 41 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
               Write(Html.DisplayFor(model => item.Birth));

#line default
#line hidden
                EndContext();
                BeginContext(1080, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1148, 34, false);
#line 44 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
               Write(Html.DisplayFor(model => item.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1182, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1250, 37, false);
#line 47 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
               Write(Html.DisplayFor(model => item.Childs));

#line default
#line hidden
                EndContext();
                BeginContext(1287, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1355, 37, false);
#line 50 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
               Write(Html.DisplayFor(model => item.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(1392, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1460, 39, false);
#line 53 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
               Write(Html.DisplayFor(model => item.Category));

#line default
#line hidden
                EndContext();
                BeginContext(1499, 69, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1568, "\"", 1625, 1);
#line 56 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
WriteAttributeValue("", 1575, Url.Action("Teacher", "Main", new {id = item.Id}), 1575, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1626, 53, true);
                WriteLiteral(">Edit</a>\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 59 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\AllTeachers.cshtml"
        }

#line default
#line hidden
                BeginContext(1690, 40, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
            BeginContext(1737, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<UniversityDataBase.Models.Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
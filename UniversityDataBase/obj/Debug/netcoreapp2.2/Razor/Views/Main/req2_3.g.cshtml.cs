#pragma checksum "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acb62662a0e2a69b9577cc4e90c75d89f0e7879e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_req2_3), @"mvc.1.0.view", @"/Views/Main/req2_3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/req2_3.cshtml", typeof(AspNetCore.Views_Main_req2_3))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb62662a0e2a69b9577cc4e90c75d89f0e7879e", @"/Views/Main/req2_3.cshtml")]
    public class Views_Main_req2_3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<UniversityDataBase.Models.Teacher>>
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
            BeginContext(78, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acb62662a0e2a69b9577cc4e90c75d89f0e7879e4152", async() => {
                BeginContext(84, 48, true);
                WriteLiteral("\r\n    <title>Request 2 by Category</title>\r\n    ");
                EndContext();
                BeginContext(132, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "acb62662a0e2a69b9577cc4e90c75d89f0e7879e4581", async() => {
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
                BeginContext(195, 2, true);
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
            BeginContext(204, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(206, 1439, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acb62662a0e2a69b9577cc4e90c75d89f0e7879e6797", async() => {
                BeginContext(212, 380, true);
                WriteLiteral(@"
<h3>Request 2 by Category</h3>
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
            <th>Avard</th>
            <th>Group</th>
        </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 27 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(641, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(702, 33, false);
#line 31 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
               Write(Html.DisplayFor(model => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(735, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(803, 35, false);
#line 34 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
               Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(838, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(906, 34, false);
#line 37 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
               Write(Html.DisplayFor(model => item.Sex));

#line default
#line hidden
                EndContext();
                BeginContext(940, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1008, 36, false);
#line 40 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
               Write(Html.DisplayFor(model => item.Birth));

#line default
#line hidden
                EndContext();
                BeginContext(1044, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1112, 34, false);
#line 43 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
               Write(Html.DisplayFor(model => item.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1146, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1214, 37, false);
#line 46 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
               Write(Html.DisplayFor(model => item.Childs));

#line default
#line hidden
                EndContext();
                BeginContext(1251, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1319, 37, false);
#line 49 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
               Write(Html.DisplayFor(model => item.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(1356, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1424, 39, false);
#line 52 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
               Write(Html.DisplayFor(model => item.Category));

#line default
#line hidden
                EndContext();
                BeginContext(1463, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 55 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
        }

#line default
#line hidden
                BeginContext(1518, 74, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <text>Number of teachers:</text>\r\n    ");
                EndContext();
                BeginContext(1593, 35, false);
#line 59 "C:\Users\simonAsus\RiderProjects\SharpCourse\UniversityDataBase\Views\Main\req2_3.cshtml"
Write(Html.DisplayFor(model=>model.Count));

#line default
#line hidden
                EndContext();
                BeginContext(1628, 10, true);
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
            BeginContext(1645, 9, true);
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
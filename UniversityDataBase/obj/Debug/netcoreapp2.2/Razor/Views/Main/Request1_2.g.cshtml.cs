#pragma checksum "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "701832807fbd9472706d869be843794c368173b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Request1_2), @"mvc.1.0.view", @"/Views/Main/Request1_2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Request1_2.cshtml", typeof(AspNetCore.Views_Main_Request1_2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701832807fbd9472706d869be843794c368173b5", @"/Views/Main/Request1_2.cshtml")]
    public class Views_Main_Request1_2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<UniversityDataBase.Models.Student>>
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
            BeginContext(78, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701832807fbd9472706d869be843794c368173b54161", async() => {
                BeginContext(84, 58, true);
                WriteLiteral("\r\n    <title>Request 1 by Faculty and Course</title>\r\n    ");
                EndContext();
                BeginContext(142, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "701832807fbd9472706d869be843794c368173b54600", async() => {
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
                BeginContext(205, 2, true);
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
            BeginContext(214, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(216, 1447, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701832807fbd9472706d869be843794c368173b56816", async() => {
                BeginContext(222, 390, true);
                WriteLiteral(@"
<h3>Request 1 by Faculty and Course</h3>
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
#line 27 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(661, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(722, 33, false);
#line 31 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
               Write(Html.DisplayFor(model => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(755, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(823, 35, false);
#line 34 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
               Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(858, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(926, 34, false);
#line 37 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
               Write(Html.DisplayFor(model => item.Sex));

#line default
#line hidden
                EndContext();
                BeginContext(960, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1028, 36, false);
#line 40 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
               Write(Html.DisplayFor(model => item.Birth));

#line default
#line hidden
                EndContext();
                BeginContext(1064, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1132, 34, false);
#line 43 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
               Write(Html.DisplayFor(model => item.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1166, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1234, 36, false);
#line 46 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
               Write(Html.DisplayFor(model => item.Child));

#line default
#line hidden
                EndContext();
                BeginContext(1270, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1338, 36, false);
#line 49 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
               Write(Html.DisplayFor(model => item.Award));

#line default
#line hidden
                EndContext();
                BeginContext(1374, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1442, 39, false);
#line 52 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
               Write(Html.DisplayFor(model => item.GroupNum));

#line default
#line hidden
                EndContext();
                BeginContext(1481, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 55 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
        }

#line default
#line hidden
                BeginContext(1536, 74, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <text>Number of students:</text>\r\n    ");
                EndContext();
                BeginContext(1611, 35, false);
#line 59 "A:\Documents\CSharpCourse\UniversityDataBase\Views\Main\Request1_2.cshtml"
Write(Html.DisplayFor(model=>model.Count));

#line default
#line hidden
                EndContext();
                BeginContext(1646, 10, true);
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
            BeginContext(1663, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<UniversityDataBase.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591

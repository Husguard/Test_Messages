#pragma checksum "C:\Users\Админ\source\repos\TestTask\TestTask\Views\Home\GetMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b2abd0a05a3998a770eea9b91090d8f25db926d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetMessages), @"mvc.1.0.view", @"/Views/Home/GetMessages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetMessages.cshtml", typeof(AspNetCore.Views_Home_GetMessages))]
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
#line 1 "C:\Users\Админ\source\repos\TestTask\TestTask\Views\_ViewImports.cshtml"
using TestTask;

#line default
#line hidden
#line 2 "C:\Users\Админ\source\repos\TestTask\TestTask\Views\_ViewImports.cshtml"
using TestTask.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b2abd0a05a3998a770eea9b91090d8f25db926d", @"/Views/Home/GetMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05cf8f63ba1d33f6434e3ef320625887168eb93", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestTask.Models.Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 43, true);
            WriteLiteral("\r\n\r\n<table>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(89, 21, false);
#line 6 "C:\Users\Админ\source\repos\TestTask\TestTask\Views\Home\GetMessages.cshtml"
           Write(Html.Label("User ID"));

#line default
#line hidden
            EndContext();
            BeginContext(110, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(134, 21, false);
#line 7 "C:\Users\Админ\source\repos\TestTask\TestTask\Views\Home\GetMessages.cshtml"
           Write(Html.Label("Message"));

#line default
#line hidden
            EndContext();
            BeginContext(155, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 9 "C:\Users\Админ\source\repos\TestTask\TestTask\Views\Home\GetMessages.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(226, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(287, 41, false);
#line 13 "C:\Users\Админ\source\repos\TestTask\TestTask\Views\Home\GetMessages.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(328, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(396, 39, false);
#line 16 "C:\Users\Админ\source\repos\TestTask\TestTask\Views\Home\GetMessages.cshtml"
               Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(435, 42, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>");
            EndContext();
#line 18 "C:\Users\Админ\source\repos\TestTask\TestTask\Views\Home\GetMessages.cshtml"
                 }

#line default
#line hidden
            BeginContext(480, 16, true);
            WriteLiteral("    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestTask.Models.Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
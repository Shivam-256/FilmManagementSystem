#pragma checksum "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\LanguageController2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "157f2b6a46532de4add9231ee7e2e60ec333ee69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LanguageController2_Index), @"mvc.1.0.view", @"/Views/LanguageController2/Index.cshtml")]
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
#nullable restore
#line 1 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\_ViewImports.cshtml"
using AspNetCore_MVC_FMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\_ViewImports.cshtml"
using AspNetCore_MVC_FMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157f2b6a46532de4add9231ee7e2e60ec333ee69", @"/Views/LanguageController2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8007e0bb5aab4d6283504330261f0a3fb319c1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LanguageController2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AspNetCore_MVC_FMS.Models.LanguageVM>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\LanguageController2\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\LanguageController2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LanguageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\LanguageController2\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\LanguageController2\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\LanguageController2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LanguageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\LanguageController2\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 37 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\LanguageController2\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AspNetCore_MVC_FMS.Models.LanguageVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Admin\_AdminView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4a82084cff723640e840c5e3a31423da9b5b4dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__AdminView), @"mvc.1.0.view", @"/Views/Admin/_AdminView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4a82084cff723640e840c5e3a31423da9b5b4dc", @"/Views/Admin/_AdminView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8007e0bb5aab4d6283504330261f0a3fb319c1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin__AdminView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Admin\_AdminView.cshtml"
 if (Context.Request.Cookies["Role"] == "Admin" )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"btn-group\" role=\"group\" aria-label=\"...\">\r\n <button type=\"button\" class=\"btn btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 292, "\"", 366, 3);
            WriteAttributeValue("", 302, "javascript:document.location.href=\'", 302, 35, true);
#nullable restore
#line 10 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Admin\_AdminView.cshtml"
WriteAttributeValue("", 337, Url.Action("Index", "Film"), 337, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 365, "\'", 365, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Film</button>\r\n <button type=\"button\" class=\"btn btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 429, "\"", 504, 3);
            WriteAttributeValue("", 439, "javascript:document.location.href=\'", 439, 35, true);
#nullable restore
#line 11 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Admin\_AdminView.cshtml"
WriteAttributeValue("", 474, Url.Action("Index", "Actor"), 474, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 503, "\'", 503, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Actor</button>\r\n <button type=\"button\" class=\"btn btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 568, "\"", 646, 3);
            WriteAttributeValue("", 578, "javascript:document.location.href=\'", 578, 35, true);
#nullable restore
#line 12 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Admin\_AdminView.cshtml"
WriteAttributeValue("", 613, Url.Action("Index", "Category"), 613, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 645, "\'", 645, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Category</button>\r\n <button type=\"button\" class=\"btn btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 713, "\"", 791, 3);
            WriteAttributeValue("", 723, "javascript:document.location.href=\'", 723, 35, true);
#nullable restore
#line 13 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Admin\_AdminView.cshtml"
WriteAttributeValue("", 758, Url.Action("Index", "Language"), 758, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 790, "\'", 790, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Language</button>\r\n</div>\r\n");
#nullable restore
#line 15 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Admin\_AdminView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

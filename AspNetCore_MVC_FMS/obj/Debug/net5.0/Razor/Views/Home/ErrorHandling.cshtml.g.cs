#pragma checksum "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Home\ErrorHandling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd71d225428c86e884d68f1c131bfff3701173a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ErrorHandling), @"mvc.1.0.view", @"/Views/Home/ErrorHandling.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd71d225428c86e884d68f1c131bfff3701173a6", @"/Views/Home/ErrorHandling.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8007e0bb5aab4d6283504330261f0a3fb319c1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ErrorHandling : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Home\ErrorHandling.cshtml"
Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  
<div style=""background-color: #A52A2A; color: White; height: 10px;"">  
</div>  
<div style=""background-color: #F5F5DC; color: White; height: 170px;"">  
    <div style="" padding:20px;"">   
        <h4>  
            Sorry, an error occurred while processing your request.  
        </h4>  
        <h6>");
#nullable restore
#line 13 "C:\AspNetCore_WebApi_FMS\AspNetCore_MVC_FMS\Views\Home\ErrorHandling.cshtml"
       Write(Html.ActionLink("Go Back To Home Page", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>  \r\n        <br />  \r\n        <br />  \r\n    </div>  \r\n</div>  \r\n<div style=\"background-color: #A52A2A; color: White; height: 20px;\">  \r\n</div>  \r\n");
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

#pragma checksum "E:\Online Project\GreenCabV1\GreenCabV1\Views\Shared\_newsletter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d2adeeebe849966db692e0c5920d2a3182eb47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__newsletter), @"mvc.1.0.view", @"/Views/Shared/_newsletter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_newsletter.cshtml", typeof(AspNetCore.Views_Shared__newsletter))]
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
#line 1 "E:\Online Project\GreenCabV1\GreenCabV1\Views\_ViewImports.cshtml"
using GreenCabV1;

#line default
#line hidden
#line 2 "E:\Online Project\GreenCabV1\GreenCabV1\Views\_ViewImports.cshtml"
using GreenCabV1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d2adeeebe849966db692e0c5920d2a3182eb47", @"/Views/Shared/_newsletter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601742bc7f567d96a9c57eef3b9b7069396220e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__newsletter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 268, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""newsletter"">
        <span>Sign up for newsletter</span>
        <span><input type=""text"" name=""email"" placeholder=""Enter your email""></span>
        <a href=""#"" onclick=""SubmitNews()"">Submit</a>
       
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
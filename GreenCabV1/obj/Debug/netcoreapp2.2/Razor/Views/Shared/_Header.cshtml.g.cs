#pragma checksum "D:\Project\GIT HUB\GreenCabV1\GreenCabV1\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e49c9cbeb43b33dac4841fdaeeb4bc5806fef4ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
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
#line 1 "D:\Project\GIT HUB\GreenCabV1\GreenCabV1\Views\_ViewImports.cshtml"
using GreenCabV1;

#line default
#line hidden
#line 2 "D:\Project\GIT HUB\GreenCabV1\GreenCabV1\Views\_ViewImports.cshtml"
using GreenCabV1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49c9cbeb43b33dac4841fdaeeb4bc5806fef4ee", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601742bc7f567d96a9c57eef3b9b7069396220e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 404, true);
            WriteLiteral(@"<div class=""header-section"">
	<!---
	<div class=""top-header"">
		<div class=""container"">
			<ul class=""top-menu clearfix"">
				<li><a href=""#"">Login</a></li>
				<li><a href=""#"">Register</a></li>
			</ul>
		</div>
	</div>--->
	<!-- Navigation -->
	<nav class=""navbar navbar-expand-lg navbar-dark bg-dark fixed-top"">
		<div class=""container"">
			<a class=""navbar-brand"" href=""index"">
				<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 404, "\"", 450, 1);
#line 15 "D:\Project\GIT HUB\GreenCabV1\GreenCabV1\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 410, Url.Content("~/assets/images/logo.png"), 410, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(451, 2115, true);
            WriteLiteral(@" width=""150"" height=""30"" alt="""">
			</a>
			<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
				<span class=""navbar-toggler-icon""></span>
			</button>
			<div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto navbar-right"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/corporate-carpool"">
                            Corporate carpool
                            <span class=""sr-only"">(current)</span>
                        </a>
                    </li>
                    <!--<li class=""nav-item"">
      <a class=""nav-link"" href=""daily-carpool.php"">Daily carpool</a>
    </li>-->
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/carpool"">Monthly cab</a>
                    </li>
                    <li class=");
            WriteLiteral(@"""nav-item"">
                        <a class=""nav-link"" href=""/csr"">CSR/SUPPORT</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""http://blogs.greencar.ngo/"" target=""_blank"">BLOGS</a>
                    </li>
                </ul>
			</div>
			<div class=""nav-icon sidenav"" id=""mySidenav"">
				<a href=""javascript:void(0)"" class=""closebtn"" onclick=""closeNav()"">&times;</a>
				<!--<a href=""#""><img src=""images/nav-icon.png"" alt=""Nav icon""></a>-->
				<div class=""add-menu"">
					<ul class=""left-menu"">
						<li><a href=""corporate-carpool"">Carporate carpool</a></li>
						<li><a href=""aboutus"">About greencar</a></li>
						<li><a href=""greencar-benefits"">Benifits of using greencar</a></li>
						<li><a href=""support"">Support the cause</a></li>
						<li><a href=""how-it-work"">How it work</a></li>

						<li><a href=""contactus"">Contact us</a></li>
					</ul>
				</div>
			</div>
			<div id=""main"">
				<span class=""menu-ic");
            WriteLiteral("on\" style=\"font-size:30px;cursor:pointer;\" onclick=\"openNav()\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2566, "\"", 2616, 1);
#line 58 "D:\Project\GIT HUB\GreenCabV1\GreenCabV1\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 2572, Url.Content("~/assets/images/nav-icon.png"), 2572, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2617, 63, true);
            WriteLiteral(" alt=\"Nav icon\"></span>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</nav>\r\n\r\n</div>");
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

#pragma checksum "E:\Online Project\GreenCabV1\GreenCabV1\Views\Home\csr.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "567f94588f2f84b7537ec1d09bd7d7dd5e468176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_csr), @"mvc.1.0.view", @"/Views/Home/csr.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/csr.cshtml", typeof(AspNetCore.Views_Home_csr))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567f94588f2f84b7537ec1d09bd7d7dd5e468176", @"/Views/Home/csr.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601742bc7f567d96a9c57eef3b9b7069396220e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_csr : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/globe-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Online Project\GreenCabV1\GreenCabV1\Views\Home\csr.cshtml"
  
	ViewData["Title"] = "csr";
	Layout = "~/Views/Shared/_LayoutMainV1.cshtml";

#line default
#line hidden
            BeginContext(88, 3317, true);
            WriteLiteral(@"<style>
	.top-header {
		display: none;
	}

	.csr-services {
		border-bottom: 1px solid #45c96a;
		padding-bottom: 30px;
	}

		.csr-services h2 {
			text-transform: capitalize !important;
			font-size: 25px !important;
		}

	.globe-icon {
		position: relative;
	}

		.globe-icon img {
			margin: 0 auto;
			position: absolute;
			top: -45px;
		}

	.globe-line hr {
		margin-top: 20px;
		margin-bottom: 20px;
		border: 0;
		border-top: 2px solid #45c96a;
	}

	.globe-section {
		padding: 20px 0;
		margin-top: 0;
	}

	.get-intouch h2 {
		text-transform: uppercase;
		font-size: 36px !important;
		font-weight: 500;
		color: #000;
		padding-bottom: 10px;
	}

	.get-intouch p {
		padding-bottom: 25px;
		font-weight: 500;
	}

	.services-parag {
		font-weight: 500;
		font-size: 30px;
		margin-top: 9px;
		padding-bottom: 0;
	}

	.footer {
		padding-left: 20px !important;
	}

	h2 {
		text-transform: capitalize !important;
		font-size: 25px !important;
		color: #");
            WriteLiteral(@"45c96a !important;
	}

	.newsletter a {
		font-size: 18px !important;
		width: 25%;
		border: 1px solid #45c96a !important;
	}

	p {
		font-size: 18px;
		line-height: 26px;
	}
</style>
<div class=""banner-section"">
	<img src=""assets/images/banner-csr.jpg"" alt=""images"">
</div>



<div class=""aboutus"">
	<div class=""container services"">
		<div class=""row"">
			<div class=""col-md-3""></div>
			<div class=""col-md-6"">
				<h1>We Need Your Support</h1>
				<p class=""services-parag"">We reciprocate your support.</p>
			</div>
			<div class=""col-md-3""></div>
		</div>
		<div class=""row"">
			<div class=""col-md-6 icons"">
				<div class=""services-name csr-services"">
					<h2>Grab the Eyeballs</h2>
					<p>We showcase your name in our website and Mobile App which reaches to millions.</p>
				</div>
			</div>

			<div class=""col-md-6 icons"">
				<div class=""services-name csr-services"">
					<h2>We make you reach board rooms</h2>
					<p>Through our PPTs, we put our supporters at the for-");
            WriteLiteral(@"front of corporate pitches.</p>
				</div>
			</div>
		</div>
		<div class=""row"">
			<div class=""col-md-6 icons"">
				<div class=""services-name"">
					<h2>We brag about your support</h2>
					<p>We show off your brand through on-ground activities, Event and Promotions.</p>
				</div>
			</div>
			<div class=""col-md-6 icons"">
				<div class=""services-name"">
					<h2>Do good be good</h2>
					<p>Greencar app comes with your branding. While you do good to your employees. You spread brand awareness & loyalty too</p>
				</div>
			</div>

		</div>
		<div class=""row"">
			<div class=""col-md-6 icons"">
				<div class=""services-name"">
					<h2>Spread the good word </h2>
					<p>We give you exposure through Event, Promotions and through our social media channels.</p>
				</div>
			</div>
			<div class=""col-md-6 icons"">
				<div class=""services-name"">
					<h2>Build brand loyalty</h2>
					<p>Greencar app is safe and eco-friendly. We care for women safety. When you use it shows that you care.");
            WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-1 icons\"></div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n<div class=\"globe-section\">\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-md-12\">\r\n\t\t\t\t<div class=\"heading-hr-line\">\r\n\t\t\t\t\t<span>");
            EndContext();
            BeginContext(3405, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "567f94588f2f84b7537ec1d09bd7d7dd5e4681769288", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3458, 753, true);
            WriteLiteral(@"</span>
				</div>
			</div>
		</div>
	</div>
</div>
<div class=""container"" style=""padding-bottom:30px;"">
	<div class=""row"">
		<div class=""col-md-3 icons""></div>
		<div class=""col-md-6 services-name"" style=""margin-top:0;"">
			<h2 style=""font-size:36px;font-weight:500;"">But most importantly</h2>
			<p>By supporting our endeavor you are working towards making it a greener planet for the generations to come.</p>
		</div>
		<div class=""col-md-3 icons""></div>
	</div>
</div>


<div class=""newsletter-section"">
	<div class=""container"">
		<div class=""newsletter get-intouch"">
			<h2>Get in touch</h2>
			<p>To know more or to know how can you support us. </p>
			<div class=""col-md-2""></div>
			<div class=""col-md-8 col-xl-9"">
				");
            EndContext();
            BeginContext(4211, 993, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "567f94588f2f84b7537ec1d09bd7d7dd5e46817611321", async() => {
                BeginContext(4287, 910, true);
                WriteLiteral(@"
					<div class=""row"">
						<div class=""col-md-4"">
							<div class=""md-form"">
								<input type=""text"" id=""name"" name=""name"" class=""form-control"" placeholder=""Name"">
							</div>
						</div>
						<div class=""col-md-4"">
							<div class=""md-form"">
								<input type=""text"" id=""email"" name=""email"" class=""form-control"" placeholder=""Email"">
							</div>
						</div>
						<div class=""col-md-4"">
							<div class=""md-form"" style=""margin-bottom:20px;"">
								<input type=""text"" id=""phone"" name=""phone"" class=""form-control"" placeholder=""Phone"">
							</div>
						</div>
					</div>
					<div class=""row"">
						<div class=""col-md-12"">
							<div class=""md-form"" style=""margin-bottom:20px;"">
								<textarea type=""text"" id=""message"" name=""message"" rows=""4"" placeholder=""Comments"" class=""form-control md-textarea""></textarea>
							</div>

						</div>
					</div>
				");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5204, 265, true);
            WriteLiteral(@"

				<div class=""center-on-small-only"">
					<a class=""btn btn-primary"" onclick=""document.getElementById('contact-form').submit();"">Contact us</a>
				</div>
				<div class=""status""></div>
			</div>
			<div class=""col-md-2""></div>
		</div>
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
#pragma checksum "/Users/lovrobosancic/Desktop/Switch/Views/Home/Galerija.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ccfa7449d75cf0da745987d164c1eb209a02c6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Galerija), @"mvc.1.0.view", @"/Views/Home/Galerija.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Galerija.cshtml", typeof(AspNetCore.Views_Home_Galerija))]
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
#line 1 "/Users/lovrobosancic/Desktop/Switch/Views/_ViewImports.cshtml"
using Switch;

#line default
#line hidden
#line 2 "/Users/lovrobosancic/Desktop/Switch/Views/_ViewImports.cshtml"
using Switch.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ccfa7449d75cf0da745987d164c1eb209a02c6f", @"/Views/Home/Galerija.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff4658d916538be126114ae7f2ceacdc94ed78b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Galerija : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/lovrobosancic/Desktop/Switch/Views/Home/Galerija.cshtml"
  
    ViewData["Title"] = "Galerija";

#line default
#line hidden
            BeginContext(44, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(49, 17, false);
#line 4 "/Users/lovrobosancic/Desktop/Switch/Views/Home/Galerija.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(66, 211, true);
            WriteLiteral("</h2>\r\n\r\n<iframe width=\"850\" height=\"478\" src=\"https://www.youtube.com/embed/OsZdzMxLWO0\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>");
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

#pragma checksum "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Wedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747fd9721c6414dc9631d365b129a37bb7e56bb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Wedding), @"mvc.1.0.view", @"/Views/Home/Wedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Wedding.cshtml", typeof(AspNetCore.Views_Home_Wedding))]
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
#line 1 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747fd9721c6414dc9631d365b129a37bb7e56bb2", @"/Views/Home/Wedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d73c63ee1405aed717ee924d2dd8f76574c8e5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Wedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(5, 25, false);
#line 1 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Wedding.cshtml"
Write(ViewBag.Wedding.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(30, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(36, 25, false);
#line 1 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Wedding.cshtml"
                              Write(ViewBag.Wedding.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(61, 67, true);
            WriteLiteral("</h1>\r\n<a>Dashboard</a>\r\n<a>Log Out</a>\r\n\r\n<hr>\r\n\r\n<h2>Date:</h2>\r\n");
            EndContext();
            BeginContext(129, 44, false);
#line 8 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Wedding.cshtml"
Write(ViewBag.Wedding.Date.ToString("MMM dd yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(173, 21, true);
            WriteLiteral("\r\n<h2>Address:</h2>\r\n");
            EndContext();
            BeginContext(195, 23, false);
#line 10 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Wedding.cshtml"
Write(ViewBag.Wedding.Address);

#line default
#line hidden
            EndContext();
            BeginContext(218, 26, true);
            WriteLiteral("\r\n<h2>Guests:</h2>\r\n<ul>\r\n");
            EndContext();
#line 13 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Wedding.cshtml"
     foreach (var guest in @ViewBag.Wedding.Attendees) {

#line default
#line hidden
            BeginContext(302, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(315, 20, false);
#line 14 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Wedding.cshtml"
       Write(guest.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(335, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(337, 19, false);
#line 14 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Wedding.cshtml"
                             Write(guest.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(356, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 15 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Wedding.cshtml"
    }

#line default
#line hidden
            BeginContext(370, 5, true);
            WriteLiteral("</ul>");
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

#pragma checksum "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7ccc0183feab6326898b3f559cd21c064826bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7ccc0183feab6326898b3f559cd21c064826bde", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d73c63ee1405aed717ee924d2dd8f76574c8e5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 66, true);
            WriteLiteral("<h1>Welcome to the Wedding Planner</h1>\r\n<a>Sign Out</a>\r\n\r\n<hr>\r\n");
            EndContext();
            BeginContext(67, 22, false);
#line 5 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
Write(ViewBag.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(89, 115, true);
            WriteLiteral(" \r\n<table>\r\n    <tr>\r\n    <th>Wedding</th>\r\n    <th>Date</th>\r\n    <th>Guest</th>\r\n    <th>Action</th>\r\n    </tr>\r\n");
            EndContext();
#line 13 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
     foreach (var wedding in @ViewBag.Weddings) {

#line default
#line hidden
            BeginContext(255, 32, true);
            WriteLiteral("        <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 287, "\"", 320, 2);
            WriteAttributeValue("", 294, "wedding/", 294, 8, true);
#line 15 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 302, wedding.WeddingId, 302, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(321, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(323, 17, false);
#line 15 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                Write(wedding.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(340, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(344, 17, false);
#line 15 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                                                                     Write(wedding.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(361, 27, true);
            WriteLiteral("</a></td>\r\n            <td>");
            EndContext();
            BeginContext(389, 36, false);
#line 16 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
           Write(wedding.Date.ToString("MMM dd yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(425, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(449, 23, false);
#line 17 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
           Write(wedding.Attendees.Count);

#line default
#line hidden
            EndContext();
            BeginContext(472, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 20 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                 if(@wedding.Attendees[0].User.UserId == ViewBag.User.UserId) {

#line default
#line hidden
            BeginContext(652, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 674, "\"", 707, 2);
            WriteAttributeValue("", 681, "/Delete/", 681, 8, true);
#line 21 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 689, wedding.WeddingId, 689, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(708, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 22 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                } else { 
                    bool temp = false;
                    

#line default
#line hidden
#line 24 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                     foreach (var attendingwedding in @ViewBag.User.WeddingAttending)
                    {
                        

#line default
#line hidden
#line 26 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                         if(@attendingwedding.WeddingId == @wedding.WeddingId) { 

#line default
#line hidden
            BeginContext(981, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1011, "\"", 1043, 2);
            WriteAttributeValue("", 1018, "UnRSVP/", 1018, 7, true);
#line 27 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1025, wedding.WeddingId, 1025, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1044, 14, true);
            WriteLiteral(">Un-RSVP</a>\r\n");
            EndContext();
#line 28 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                            temp = true;
                        }

#line default
#line hidden
#line 29 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                         
                    }

#line default
#line hidden
#line 31 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                     if (temp == false) {

#line default
#line hidden
            BeginContext(1193, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1219, "\"", 1250, 2);
            WriteAttributeValue("", 1226, "/RSVP/", 1226, 6, true);
#line 32 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1232, wedding.WeddingId, 1232, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1251, 11, true);
            WriteLiteral(">RSVP</a>\r\n");
            EndContext();
#line 33 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                    }

#line default
#line hidden
#line 33 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(1304, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "C:\Users\randy\Documents\Code\CodingDojo\C Sharp\orms\WeddingPlanner\Views\Home\Dashboard.cshtml"
    }

#line default
#line hidden
            BeginContext(1345, 59, true);
            WriteLiteral("</table>\r\n\r\n\r\n<hr>\r\n\r\n<a href=\"/NewWedding\">New Wedding</a>");
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
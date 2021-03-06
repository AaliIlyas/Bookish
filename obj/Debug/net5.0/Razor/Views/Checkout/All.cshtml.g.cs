#pragma checksum "C:\.Training\Bookish\Views\Checkout\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f362a9adbee2847726818203234b8b7472c3d68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_All), @"mvc.1.0.view", @"/Views/Checkout/All.cshtml")]
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
#line 1 "C:\.Training\Bookish\Views\_ViewImports.cshtml"
using Bookish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\.Training\Bookish\Views\_ViewImports.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f362a9adbee2847726818203234b8b7472c3d68", @"/Views/Checkout/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CheckoutViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
  
    var booksOnLoan = Model.Where(checkout => !checkout.DateReturned.HasValue);
    var pastBooks = Model.Where(c => c.DateReturned.HasValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2> Books currently on loan </h2>\r\n");
#nullable restore
#line 8 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
  
    if (booksOnLoan.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No books on loan right now.</p>\r\n");
#nullable restore
#line 12 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-responsive table-hover width: fit-content"">
            <tr>
                <th>Title</th>
                <th>Author</th>
                <th>Member Name</th>
                <th>Date Loaned</th>
                <th>Date to return</th>
                <th>View / Edit</th>
            </tr>

");
#nullable restore
#line 25 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
             foreach (var checkout in booksOnLoan)
            {
                var returnDate = (@checkout.DateReturned == null) ? "Unreturned" : checkout.DateReturned?.ToString("dd/MM/yyyy");


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.Book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.Member.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.DateLoaned.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.DateDue.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1239, "\"", 1275, 2);
            WriteAttributeValue("", 1246, "/checkout/borrow/", 1246, 17, true);
#nullable restore
#line 35 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
WriteAttributeValue("", 1263, checkout.Id, 1263, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>View / Edit</button></a></td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 39 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Books loaned in the past</h2>\r\n");
#nullable restore
#line 43 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
  
    if (pastBooks.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Empty.</p>\r\n");
#nullable restore
#line 47 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table>
            <tr>
                <th>Title</th>
                <th>Author</th>
                <th>Member Name</th>
                <th>Date Loaned</th>
                <th>Date to return</th>
                <th>Returned on Date</th>
                <th>View / Edit</th>
            </tr>

");
#nullable restore
#line 61 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
             foreach (var checkout in Model)
            {
                var returnDate = (@checkout.DateReturned == null) ? "Unreturned" : checkout.DateReturned?.ToString("dd/MM/yyyy");


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 66 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.Book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.Member.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.DateLoaned.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(checkout.DateDue.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
                   Write(returnDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2413, "\"", 2449, 2);
            WriteAttributeValue("", 2420, "/checkout/borrow/", 2420, 17, true);
#nullable restore
#line 72 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
WriteAttributeValue("", 2437, checkout.Id, 2437, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>View / Edit</button></a></td>\r\n                </tr>\r\n");
#nullable restore
#line 74 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 76 "C:\.Training\Bookish\Views\Checkout\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<a href=\"/checkout/new\">Checkout a new book</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<CheckoutViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

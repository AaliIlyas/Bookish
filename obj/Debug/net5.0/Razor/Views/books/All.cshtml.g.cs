#pragma checksum "C:\Training\Bookish\bookish1\Views\books\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1ee66a71f74f0b0661e07a52b815295284aee20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_books_All), @"mvc.1.0.view", @"/Views/books/All.cshtml")]
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
#line 1 "C:\Training\Bookish\bookish1\Views\_ViewImports.cshtml"
using Bookish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Training\Bookish\bookish1\Views\_ViewImports.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ee66a71f74f0b0661e07a52b815295284aee20", @"/Views/books/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_books_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<BookViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Books</h1>\r\n\r\n");
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Author</th>\r\n        <th>Title</th>\r\n        <th>Genre</th>\r\n        <th>Number of Copies</th>\r\n        <th>View / Edit</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 21 "C:\Training\Bookish\bookish1\Views\books\All.cshtml"
     foreach (var book in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Training\Bookish\bookish1\Views\books\All.cshtml"
           Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Training\Bookish\bookish1\Views\books\All.cshtml"
           Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Training\Bookish\bookish1\Views\books\All.cshtml"
           Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Training\Bookish\bookish1\Views\books\All.cshtml"
           Write(book.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Training\Bookish\bookish1\Views\books\All.cshtml"
           Write(book.NumberOfCopies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 735, "\"", 766, 2);
            WriteAttributeValue("", 742, "/books/bookpage/", 742, 16, true);
#nullable restore
#line 29 "C:\Training\Bookish\bookish1\Views\books\All.cshtml"
WriteAttributeValue("", 758, book.Id, 758, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>View / Edit</button></a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Training\Bookish\bookish1\Views\books\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<br />\r\n<a href=\"/books/new\">Create new book</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<BookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69b87f31634b22eabeddda0f0ff8d532ea2a0651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\_ViewImports.cshtml"
using CoreDemo2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\_ViewImports.cshtml"
using CoreDemo2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b87f31634b22eabeddda0f0ff8d532ea2a0651", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187cf4a194abdb31472ff7153f828bc7c928575c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h4>Yazar??n Bloglar??</h4>
<table class=""table table-bordered"">
    <tr>
        <td>#</td>
        <td>Blog Ba??l??????</td>
        <td>Olu??turma Tarihi</td>
        <td>Kategori</td>
        <td>Durum</td>
        <td>Sil</td>
        <td>D??zenle</td>
    </tr>
");
#nullable restore
#line 20 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
     foreach(var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th>");
#nullable restore
#line 23 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
           Write(x.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 24 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
           Write(x.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 25 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
           Write(x.BlogCreateDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 26 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
           Write(x.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 27 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
           Write(x.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th><a");
            BeginWriteAttribute("href", " href=\"", 713, "\"", 746, 2);
            WriteAttributeValue("", 720, "/Blog/BlogDelete/", 720, 17, true);
#nullable restore
#line 28 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 737, x.BlogId, 737, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek istedi??ine emin misin?\');\" class=\"btn btn-outline-danger\">S??L</a></th>\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 869, "\"", 900, 2);
            WriteAttributeValue("", 876, "/Blog/EditBlog/", 876, 15, true);
#nullable restore
#line 29 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 891, x.BlogId, 891, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">D??ZENLE</a></th>\n        </tr>\n");
#nullable restore
#line 31 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogListByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>  \n<br />\n<a href=\"#\" class=\"btn btn-outline-info\">Yeni Blog Olu??tur</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

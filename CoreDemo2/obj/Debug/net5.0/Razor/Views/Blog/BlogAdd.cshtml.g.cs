#pragma checksum "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c983cc3b074a9d9f89a7fe357c48963f6e282fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c983cc3b074a9d9f89a7fe357c48963f6e282fa", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187cf4a194abdb31472ff7153f828bc7c928575c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <h3>Yeni Blog Yaz</h3>\n    <br />\n");
#nullable restore
#line 10 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
     using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.TextBoxFor(x=>x.BlogTitle,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.ValidationMessageFor(x=>x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n");
#nullable restore
#line 16 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.TextBoxFor(x=>x.BlogImage,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.ValidationMessageFor(x=>x.BlogImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n");
#nullable restore
#line 20 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.Label("Blog küçük görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.TextBoxFor(x=>x.BlogThumbnailImage,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n");
#nullable restore
#line 23 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.Label("Category Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.DropDownListFor(x=>x.CategoryId,(List<SelectListItem>)ViewBag.cv,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n");
#nullable restore
#line 26 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.Label("Blog İçerik"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.TextAreaFor(x=>x.BlogContent,10,3,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
   Write(Html.ValidationMessageFor(x=>x.BlogTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\n        <button class=\"btn btn-outline-primary\">Oluştur</button>\n");
#nullable restore
#line 31 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogAdd.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
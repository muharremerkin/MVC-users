#pragma checksum "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4981fb754eaa0ba15fe2cd0cd2c4e7a48fe3e2ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4981fb754eaa0ba15fe2cd0cd2c4e7a48fe3e2ad", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187cf4a194abdb31472ff7153f828bc7c928575c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<div class=\"tech-btm\">\n    <h3>BLoglar</h3>\n");
#nullable restore
#line 7 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\n            <div class=\"col-md-5 blog-grid-left\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 241, "\"", 278, 2);
            WriteAttributeValue("", 248, "/Blog/BlogReadAll/", 248, 18, true);
#nullable restore
#line 11 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 266, item.BlogId, 266, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 305, "\"", 326, 1);
#nullable restore
#line 12 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 311, item.BlogImage, 311, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 358, "\"", 364, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                </a>\n            </div>\n            <div class=\"col-md-7 blog-grid-right\">\n\n                <h5>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 502, "\"", 539, 2);
            WriteAttributeValue("", 509, "/Blog/BlogReadAll/", 509, 18, true);
#nullable restore
#line 18 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 527, item.BlogId, 527, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,125).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </h5>\n                <div class=\"sub-meta\">\n                    <span>\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 22 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                Write(item.BlogCreateDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </span>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 27 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\BlogLast3Post\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

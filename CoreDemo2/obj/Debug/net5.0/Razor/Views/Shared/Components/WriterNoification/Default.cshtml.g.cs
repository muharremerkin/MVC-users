#pragma checksum "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\WriterNoification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2a58dab443222d19d9c280aa4599648fd0825df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNoification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNoification/Default.cshtml")]
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
#line 1 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\WriterNoification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a58dab443222d19d9c280aa4599648fd0825df", @"/Views/Shared/Components/WriterNoification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187cf4a194abdb31472ff7153f828bc7c928575c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterNoification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\n    <h6 class=\"p-3 mb-0\">Bildirimler</h6>\n");
#nullable restore
#line 6 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\WriterNoification\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\n        <a class=\"dropdown-item preview-item\">\n            <div class=\"preview-thumbnail\">\n                <div");
            BeginWriteAttribute("class", " class=\"", 408, "\"", 439, 1);
#nullable restore
#line 11 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\WriterNoification\Default.cshtml"
WriteAttributeValue("", 416, item.NotificationColor, 416, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <i");
            BeginWriteAttribute("class", " class=\"", 464, "\"", 500, 1);
#nullable restore
#line 12 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\WriterNoification\Default.cshtml"
WriteAttributeValue("", 472, item.NotificationTypeSymbol, 472, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                </div>\n            </div>\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\n                <h6 class=\"preview-subject font-weight-normal mb-1\">");
#nullable restore
#line 16 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\WriterNoification\Default.cshtml"
                                                               Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                <p class=\"text-gray ellipsis mb-0\"> ");
#nullable restore
#line 17 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\WriterNoification\Default.cshtml"
                                               Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n            </div>\n        </a>\n");
#nullable restore
#line 20 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Shared\Components\WriterNoification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \n\n    <h6 class=\"p-3 mb-0 text-center\">Tüm Bildirimleri Gör</h6>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99be5a82b80fcd41aad5e1b2a2dd0eccfe861a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogReadAll), @"mvc.1.0.view", @"/Views/Blog/BlogReadAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99be5a82b80fcd41aad5e1b2a2dd0eccfe861a91", @"/Views/Blog/BlogReadAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187cf4a194abdb31472ff7153f828bc7c928575c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogReadAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<section class=\"banner-bottom\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-lg-8 left-blog-info-w3layouts-agileits text-left\">\n");
#nullable restore
#line 13 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
                 foreach (var x in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"blog-grid-top\">\n                        <div class=\"b-grid-top\">\n                            <div class=\"blog_info_left_grid\">\n                                <a href=\"single.html\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99be5a82b80fcd41aad5e1b2a2dd0eccfe861a915576", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </div>
                            <div class=""blog-info-middle"">
                                <ul>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 26 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
                                                                           Write(x.BlogCreateDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-thumbs-up""></i> 0 Beğeni
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 0 Yorum
                                        </a>
                                    </li>

                                </ul>
                            </div>
                        </div>

                        <h3>
                            <a href=""single.html"">");
#nullable restore
#line 45 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
                                             Write(x.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                        </h3>\n                        <p>\n                          ");
#nullable restore
#line 48 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
                     Write(x.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n                    </div>\n");
#nullable restore
#line 51 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \n                ");
#nullable restore
#line 53 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
           Write(await Component.InvokeAsync("CommentListByBlog",new{ id = ViewBag.i }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                   ");
#nullable restore
#line 55 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
              Write(await Html.PartialAsync("~/Views/Comment/PartialAddComment.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n\n            <aside class=\"col-lg-4 agileits-w3ls-right-blog-con text-right\">\n                <div class=\"right-blog-info text-left\">\n                    <div class=\"tech-btm\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99be5a82b80fcd41aad5e1b2a2dd0eccfe861a919995", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n\n                    ");
#nullable restore
#line 64 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
               Write(await Html.PartialAsync("~/Views/NewsLetterContorller/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    ");
#nullable restore
#line 66 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
               Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                   \n                    ");
#nullable restore
#line 68 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Blog\BlogReadAll.cshtml"
               Write(await Component.InvokeAsync("WritetLastBlog"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <div class=""single-gd my-5 tech-btm"">
                        <h4>Our Progress</h4>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""");
            WriteLiteral(@"progress"">
                            <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
                                 aria-valuemax=""100""></div>
                        </div>
                    </div>
                    <div class=""single-gd tech-btm"">
                        <h4>Son Eklenen Post</h4>
                        <div class=""blog-grids"">
                            <div class=""blog-grid-left"">
                                <a href=""single.html"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99be5a82b80fcd41aad5e1b2a2dd0eccfe861a9114158", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </div>
                            <div class=""blog-grid-right"">

                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                                </h5>
                            </div>
                            <div class=""clearfix""> </div>
                        </div>
                    </div>
                </div>

            </aside>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

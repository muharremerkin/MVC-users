#pragma checksum "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f35b9389fb56b4ae1090f58a64d921d417873310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f35b9389fb56b4ae1090f58a64d921d417873310", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187cf4a194abdb31472ff7153f828bc7c928575c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f35b9389fb56b4ae1090f58a64d921d4178733104223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f35b9389fb56b4ae1090f58a64d921d4178733105260", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<div class=\"container\">\n<section class=\"main-content-w3layouts-agileits\">\n    \n        <h3 class=\"tittle\">Kayıt Ol!</h3>\n        <div class=\"inner-sec\">\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\n");
#nullable restore
#line 15 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\n                        <div class=\"col-md-6 mb-3\">\n                            <label for=\"validationCustom01\">Ad - Soyad</label>\n\n");
            WriteLiteral("                            ");
#nullable restore
#line 22 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.WriterName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 23 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterName,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"col-md-6 mb-3\">\n                            <label for=\"validationCustom02\">E-Posta</label>\n");
            WriteLiteral("                            ");
#nullable restore
#line 28 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.WriterMail,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 29 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterMail,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Şifre</label>
                            <input type=""password"" class=""form-control"" id=""password1"" name=""WriterPassword""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1970, "\"", 1984, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 1985, "\"", 1996, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            ");
#nullable restore
#line 36 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x=>x.WriterPassword,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword2 mb-2"">Şifre Tekrar</label>
                              <input type=""password"" class=""form-control"" id=""password2"" name=""ConfirmPassword""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2394, "\"", 2408, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 2409, "\"", 2420, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>

                    </div>
                    <button type=""submit"" class=""btn btn-primary submit mb-4"">Kayıt Ol</button>
                    <p>
                        <a href=""#"" id=""btn1"">Tüm şartları okudum, kabul ediyorum.</a>
                    </p>
");
#nullable restore
#line 48 "C:\Users\Muharrem\Desktop\CoreDemo2-master\CoreDemo2\Views\Register\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    \n    <script>\n        $(\'#btn1\').click(function () {\n            swal(\"Kullanıcı Hakları\",\"Gizlilik şartlarını okudum, kabul ediyorum.\");\n        });\n    </script>\n</section>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

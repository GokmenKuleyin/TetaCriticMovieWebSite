#pragma checksum "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b82738cfbaca0bc7f490fe699dee19928e058add"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_KategoriMenusu), @"mvc.1.0.view", @"/Views/Home/KategoriMenusu.cshtml")]
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
#line 1 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\_ViewImports.cshtml"
using TetaCritic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\_ViewImports.cshtml"
using TetaCritic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b82738cfbaca0bc7f490fe699dee19928e058add", @"/Views/Home/KategoriMenusu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f69d501ffe1f69cbba8df485643b32e006b0997", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_KategoriMenusu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TetaCritic.Models.Kategori>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action list-group-item-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KategoriMenusu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilmSayfasi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
  
    IEnumerable<TetaCritic.Models.Kategori> kategoriler = ViewData["Kategoriler"] as IEnumerable<TetaCritic.Models.Kategori>;
    IEnumerable<TetaCritic.Models.Film> filmler = ViewData["Filmler"] as IEnumerable<TetaCritic.Models.Film>;
    ViewData["Title"] = "Kategoriler";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row mt-md-5\">\n    <div class=\"list-group col-md-2 mb-3\">\n");
#nullable restore
#line 11 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
         foreach (var ktg in kategoriler)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82738cfbaca0bc7f490fe699dee19928e058add5262", async() => {
                WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                                                                                                                   Write(ktg.KategoriAdi);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                                                                                          WriteLiteral(ktg.KategoriId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 14 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n    <div class=\"list-group col-md-10\">\n");
#nullable restore
#line 18 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
         if (Model is null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
             foreach (var film in filmler)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card mb-3\">\n                    <div class=\"row no-gutters\">\n                        <div class=\"col-lg-2\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 950, "\"", 979, 1);
#nullable restore
#line 25 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
WriteAttributeValue("", 956, Url.Content(film.Afis), 956, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                        </div>\n                        <div class=\"col-lg-10\">\n                            <div class=\"card-body\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82738cfbaca0bc7f490fe699dee19928e058add9672", async() => {
                WriteLiteral("<h3 class=\"card-title\">");
#nullable restore
#line 29 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                                                                                 Write(film.FilmAdi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                                     WriteLiteral(film.FilmId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                <p class=\"card-text\"><b>Yönetmen:</b> ");
#nullable restore
#line 30 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                 Write(film.Yonetmen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p class=\"card-text\"><b>Çıkış Yılı:</b> ");
#nullable restore
#line 31 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                   Write(film.VizyonTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p class=\"card-text\"><b>Özet:</b> ");
#nullable restore
#line 32 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                             Write(film.Ozet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 37 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
         if (Model is not null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
             foreach (var film in Model.FilmListesi)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card mb-3\">\n                    <div class=\"row no-gutters\">\n                        <div class=\"col-lg-2\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1954, "\"", 1983, 1);
#nullable restore
#line 46 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
WriteAttributeValue("", 1960, Url.Content(film.Afis), 1960, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                        </div>\n                        <div class=\"col-lg-10\">\n                            <div class=\"card-body\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82738cfbaca0bc7f490fe699dee19928e058add15337", async() => {
                WriteLiteral("<h3 class=\"card-title\">");
#nullable restore
#line 50 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                                                                                Write(film.FilmAdi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                                    WriteLiteral(film.FilmId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                <p class=\"card-text\"><b>Yönetmen:</b> ");
#nullable restore
#line 51 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                 Write(film.Yonetmen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p class=\"card-text\"><b>Çıkış Yılı:</b> ");
#nullable restore
#line 52 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                                   Write(film.VizyonTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p class=\"card-text\"><b>Özet:</b> ");
#nullable restore
#line 53 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
                                                             Write(film.Ozet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 58 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\furka\Desktop\TetaCritic-main\TetaCritic\TetaCritic\Views\Home\KategoriMenusu.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TetaCritic.Models.Kategori> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c51afdabf25c9a0107b3951556d84c6a15a0b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EMigrant.App.Frontend.Pages.Gerencia.Pages_Gerencia_listaArticulo), @"mvc.1.0.razor-page", @"/Pages/Gerencia/listaArticulo.cshtml")]
namespace EMigrant.App.Frontend.Pages.Gerencia
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
#line 1 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\_ViewImports.cshtml"
using EMigrant.App.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c51afdabf25c9a0107b3951556d84c6a15a0b1", @"/Pages/Gerencia/listaArticulo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0547e95747cc266d5341ca58376c2605f66368", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Gerencia_listaArticulo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./editarArticulo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("<style>\r\n    .center {\r\n        text-align: center\r\n    }\r\n</style>\r\n\r\n");
            WriteLiteral(@"
<h2 class=""center"">Actualizar los datos de las novedades</h2>
<table class=""table"">
    <thead>
        <th>Id</th>
        <th>T??tulo de la novedad</th>
        <th>Fecha de la novedad</th>
        <th>D??as publicado</th>
        <th>Texto explicativo</th>
        <th>Acciones</th>
    </thead>
");
#nullable restore
#line 27 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml"
     foreach (var articulo in Model.Articulo)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml"
           Write(articulo.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml"
           Write(articulo.tituloArticulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml"
           Write(articulo.fechaNovedad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml"
           Write(articulo.diasArticulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml"
           Write(articulo.textoArticulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c51afdabf25c9a0107b3951556d84c6a15a0b16165", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articulo.id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml"
                                                                             WriteLiteral(articulo.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articulo.id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-articulo.id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articulo.id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1069, "\"", 1076, 0);
            EndWriteAttribute();
            WriteLiteral(">Inhabilitar</a>\r\n              </td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Jonathan\Downloads\EMigrant.App\emigrant.app\emigrant.app.frontend\Pages\Gerencia\listaArticulo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EMigrant.App.Frontend.Pages.ListArticuloModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EMigrant.App.Frontend.Pages.ListArticuloModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EMigrant.App.Frontend.Pages.ListArticuloModel>)PageContext?.ViewData;
        public EMigrant.App.Frontend.Pages.ListArticuloModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

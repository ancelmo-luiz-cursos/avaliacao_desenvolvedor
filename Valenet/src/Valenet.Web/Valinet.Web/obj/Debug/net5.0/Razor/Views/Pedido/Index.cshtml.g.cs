#pragma checksum "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07ca2336ce058993676045de9b8350c54c2ef5c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
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
#line 1 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\_ViewImports.cshtml"
using Valinet.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\_ViewImports.cshtml"
using Valinet.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07ca2336ce058993676045de9b8350c54c2ef5c4", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5b40f93e67212e55ddd7e3c2b58d6f1f897990", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Valinet.Web.Models.PedidoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Pedidos</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
               Comprador
            </th>
            <th>
                Descrição
            </th>
            <th>
               Preço Unitário
            </th>
            <th>
               Quantidade
            </th>
            <th>
                Endereço
            </th>
            <th>
               Fornecedor
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comprador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrecoUnitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fornecedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "D:\Projetos\Teste\Valenet\avaliacao_desenvolvedor\Valenet\src\Valenet.Web\Valinet.Web\Views\Pedido\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Valinet.Web.Models.PedidoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
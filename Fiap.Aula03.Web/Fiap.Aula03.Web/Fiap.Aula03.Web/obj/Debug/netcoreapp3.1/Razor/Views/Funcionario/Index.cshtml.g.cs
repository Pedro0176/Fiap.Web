#pragma checksum "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4567dc77b9cfc7109689cc94f0206a0fcb6c7578"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Index), @"mvc.1.0.view", @"/Views/Funcionario/Index.cshtml")]
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
#line 1 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\_ViewImports.cshtml"
using Fiap.Aula03.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\_ViewImports.cshtml"
using Fiap.Aula03.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4567dc77b9cfc7109689cc94f0206a0fcb6c7578", @"/Views/Funcionario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306c209c15c224522cd29786a470d7393042b305", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Funcionario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Fiap.Aula03.Web.TagHelpers.TdsTagHelper __Fiap_Aula03_Web_TagHelpers_TdsTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tds", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4567dc77b9cfc7109689cc94f0206a0fcb6c75785352", async() => {
            }
            );
            __Fiap_Aula03_Web_TagHelpers_TdsTagHelper = CreateTagHelper<global::Fiap.Aula03.Web.TagHelpers.TdsTagHelper>();
            __tagHelperExecutionContext.Add(__Fiap_Aula03_Web_TagHelpers_TdsTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
WriteLiteral(TempData["msg"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Fiap_Aula03_Web_TagHelpers_TdsTagHelper.Texto = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("texto", __Fiap_Aula03_Web_TagHelpers_TdsTagHelper.Texto, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!--Link para cadastrar-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4567dc77b9cfc7109689cc94f0206a0fcb6c75786959", async() => {
                WriteLiteral("Cadastrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!--Criar uma tabela HTML e fazer um loop para exibir todos os funcionários -->
<table class=""table table-striped"">
    <tr>
        <th>Código</th>
        <th>Nome</th>
        <th>Data Nascimento</th>
        <th>Salário</th>
        <th>Ativo</th>
        <th>Cargo</th>
        <th>Setor</th>
        <th></th>
    </tr>
");
#nullable restore
#line 26 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
     foreach (var func in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 29 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
           Write(func.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
           Write(func.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
           Write(func.DataNascimento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
           Write(func.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
            Write(func.Ativo?"Sim":"Não");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
           Write(func.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
           Write(func.Setor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4567dc77b9cfc7109689cc94f0206a0fcb6c757811203", async() => {
                WriteLiteral(" Atualizar ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
                                                                     WriteLiteral(func.Codigo);

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
            WriteLiteral("\r\n                <!-- Excluir um funcionário -->\r\n                <!-- Button trigger modal -->\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1125, "\"", 1169, 3);
            WriteAttributeValue("", 1135, "funcionarioId.value", 1135, 19, true);
            WriteAttributeValue(" ", 1154, "=", 1155, 2, true);
#nullable restore
#line 40 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
WriteAttributeValue(" ", 1156, func.Codigo, 1157, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-sm btn-danger\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n                    Excluir\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\Faculdade\2º Ano\Enterprise Application Development - Thiago Toshiyuki\2º SEMESTRE\Fiap.Aula03.Web\Fiap.Aula03.Web\Fiap.Aula03.Web\Views\Funcionario\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confirmação</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Deseja realmente excluir o funcionário?
            </div>
            <div class=""modal-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4567dc77b9cfc7109689cc94f0206a0fcb6c757815512", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""funcionarioId"" />
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Não</button>
                    <button type=""submit"" class=""btn btn-danger"">Sim</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591

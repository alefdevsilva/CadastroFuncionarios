#pragma checksum "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "789663d4758e898a21428e3547276da796d220d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Details), @"mvc.1.0.view", @"/Views/Cliente/Details.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\_ViewImports.cshtml"
using LivrariaControleEmpestimo.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\_ViewImports.cshtml"
using LivrariaControleEmpestimo.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"789663d4758e898a21428e3547276da796d220d2", @"/Views/Cliente/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92644661b8bcd7104f582ec4e24278b94e976c8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LivrariaControleEmprestimos.DATA.Models.Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Cliente</h4>\r\n    <hr />\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "789663d4758e898a21428e3547276da796d220d24895", async() => {
                WriteLiteral("Alterar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
                                                       WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "789663d4758e898a21428e3547276da796d220d27179", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div class=\"card\">\r\n        <div class=\"card-header\"> Informações pessoais</div>\r\n        <div class=\"card-body row\">\r\n            <div class=\"col-md\">\r\n                <div class=\"form-group\">\r\n                    <label>");
#nullable restore
#line 22 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
                      Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input disabled class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 689, "\"", 734, 1);
#nullable restore
#line 23 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
WriteAttributeValue("", 697, Html.DisplayFor(model => model.Nome), 697, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md\">\r\n                <div class=\"form-group\">\r\n                    <label>");
#nullable restore
#line 28 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
                      Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input disabled class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 993, "\"", 1037, 1);
#nullable restore
#line 29 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
WriteAttributeValue("", 1001, Html.DisplayFor(model => model.CPF), 1001, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
            </div>
        </div>
    </div>
    <br />
    <div class=""card"">
        <div class=""card-header""> Endereço</div>
        <div class=""card-body row"">
            <div class=""col-md"">
                <div class=""form-group"">
                    <label>");
#nullable restore
#line 40 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
                      Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input disabled class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1452, "\"", 1501, 1);
#nullable restore
#line 41 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
WriteAttributeValue("", 1460, Html.DisplayFor(model => model.Endereco), 1460, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md\">\r\n                <div class=\"form-group\">\r\n                    <label>");
#nullable restore
#line 46 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
                      Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input disabled class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1763, "\"", 1810, 1);
#nullable restore
#line 47 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
WriteAttributeValue("", 1771, Html.DisplayFor(model => model.Cidade), 1771, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md\">\r\n                <div class=\"form-group\">\r\n                    <label>");
#nullable restore
#line 52 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
                      Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input disabled class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 2072, "\"", 2119, 1);
#nullable restore
#line 53 "C:\Users\DELL\Desktop\EmprestimosLivros-master\LivrariaControleEmpestimo.WEB\Views\Cliente\Details.cshtml"
WriteAttributeValue("", 2080, Html.DisplayFor(model => model.Bairro), 2080, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LivrariaControleEmprestimos.DATA.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591

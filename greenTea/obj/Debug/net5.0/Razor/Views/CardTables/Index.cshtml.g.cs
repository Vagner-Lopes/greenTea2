#pragma checksum "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210e40846e11c63aea5b2fba3c4c689057eeec53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CardTables_Index), @"mvc.1.0.view", @"/Views/CardTables/Index.cshtml")]
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
#line 1 "C:\estudos\repoRecode\greenTea\greenTea\Views\_ViewImports.cshtml"
using greenTea;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\estudos\repoRecode\greenTea\greenTea\Views\_ViewImports.cshtml"
using greenTea.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210e40846e11c63aea5b2fba3c4c689057eeec53", @"/Views/CardTables/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b08745e4d6690ee6e2a797dd012858b65c3dbb8e", @"/Views/_ViewImports.cshtml")]
    public class Views_CardTables_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<greenTea.Models.CardTable>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
  
    ViewData["Title"] = "Index";

    List<Categoria> categotias = new List<Categoria>();
    List<string> nomes = new List<string>();


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<hr />\n<br />\n<div class=\"container justify-content-center align-items-center \">\n    <div class=\"container d-flex justify-content-around align-items-center\">\n        <h1>Tabela Pictogramas</h1> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210e40846e11c63aea5b2fba3c4c689057eeec534254", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        

    </div>
    <hr />

    <div class=""filters position-sticky"">

        <!--Menu de opções-->
        <ul class=""btn-group simplefilter d-flex  flex-wrap p-2"">
            <li class=""btn btn-secondary m-1 filtr-controls rounded-pill"" data-filter=""all"">Todos</li>

");
#nullable restore
#line 27 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
             foreach (var item in Model)
            {
                if (!nomes.Contains(item.Categoria.Nome))
                {
                    nomes.Add(item.Categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"btn  m-1 filtr-controls rounded-pill text-white btn-primary\" data-filter=\"");
#nullable restore
#line 32 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.Categoria.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n            ");
#nullable restore
#line 33 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Categoria.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </li>\n");
#nullable restore
#line 35 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n        <!--Menu de opções-->\n    </div>\n\n    <!--Cards-->\n    <div class=\"cards d-flex row filter-container ml-sm-2 ml-md-3 ml-4 \">\n\n");
#nullable restore
#line 44 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card filtr-item col-3 col-sm-3 col-lg-4 card-edit\"");
            BeginWriteAttribute("style", " style=\"", 1424, "\"", 1507, 3);
            WriteAttributeValue("", 1432, "height:", 1432, 7, true);
            WriteAttributeValue(" ", 1439, "220px;background:", 1440, 18, true);
#nullable restore
#line 46 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
WriteAttributeValue(" ", 1457, Html.DisplayFor(modelItem => item.Categoria.Cor), 1458, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                 data-category=\"");
#nullable restore
#line 47 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Categoria.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sort=\"value\" data-author=\"H\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 1648, "\"", 1693, 1);
#nullable restore
#line 48 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
WriteAttributeValue("", 1654, Html.DisplayFor(modelItem => item.Img), 1654, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"sample\" />\n                <div class=\"filtr-title card-edit-textos\">\n                    <p>");
#nullable restore
#line 50 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n");
#nullable restore
#line 53 "C:\estudos\repoRecode\greenTea\greenTea\Views\CardTables\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <!--Cards-->\n</div>\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<greenTea.Models.CardTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
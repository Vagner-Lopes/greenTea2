#pragma checksum "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73cf73fb6c924104785c96cb9576571095a788e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\_ViewImports.cshtml"
using greenTea.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\_ViewImports.cshtml"
using greenTea.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using greenTea.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73cf73fb6c924104785c96cb9576571095a788e4", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8897cc6b25985b83354b19906ed3c9d9d5aab442", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cad9d3209f92217b3a402c2f7ce24588def7a101", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Confirma????o de registro";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n <div class=\"container text-center mt-5\"><h1>");
#nullable restore
#line 7 "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                                        Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></div>>\n");
#nullable restore
#line 8 "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container text-center mt-5\">\n    <p>\n    Esse aplicativo n??o envia realmente uma verifica????o, veja em <a href=\"https://aka.ms/aspaccountconf\">essa documenta????o</a>, implementa????o futura.    \n    </p>\n    </div>\n");
#nullable restore
#line 16 "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container text-center mt-5\">     \n        <p>\n                    Por favor cheque seu email.\n        </p>\n    </div>\n");
#nullable restore
#line 24 "C:\estudos\repoRecode\greenTea\greenTea\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

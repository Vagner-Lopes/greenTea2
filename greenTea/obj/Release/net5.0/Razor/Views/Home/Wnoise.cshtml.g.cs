#pragma checksum "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b897d07f6cdbda479095c19cd457833bfe293e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Wnoise), @"mvc.1.0.view", @"/Views/Home/Wnoise.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b897d07f6cdbda479095c19cd457833bfe293e8", @"/Views/Home/Wnoise.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed43d3489f07779ef06e2bd330c721a227a690d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Wnoise : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
   ViewData["Title"] = "White Noise"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<hr />\n\n");
#nullable restore
#line 7 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
  
    var Aquecedor = "/whiteNoises/Aquecedor.mp3";
    var Aspirador = "/whiteNoises/Aspirador.mp3";
    var Carro = "/whiteNoises/Carro.mp3";
    var Cascata = "/whiteNoises/Cascata.mp3";
    var Chuva = "/whiteNoises/Chuva.mp3";
    var Chuveiro = "/whiteNoises/Chuveiro.mp3";
    var Mar = "/whiteNoises/Mar.mp3";
    var Nebulizador = "/whiteNoises/Nebulizador.mp3";
    var Secador = "/whiteNoises/Secador.mp3";
    var Ulterino = "/whiteNoises/Ulterino.mp3";
    var Vento = "/whiteNoises/Vento.mp3";
    var Ventilador = "/whiteNoises/Ventilador.mp3";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container mb-5 text-center"">

        <br />
        


        <div class=""page gallery-page"">
            <section class=""clean-block clean-gallery dark"">
                <div class=""container"">
                    <div class=""block-heading"">
                        <h1 class=""text-info"">White Noise</h1>
                        <p>Escolha um tipo de som para ser ouvido como barulho de fundo.</p>
                    </div>
                    <div");
            BeginWriteAttribute("class", " class=\"", 1092, "\"", 1100, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""align-items:center; justify-content:center"">


                        <fieldset class=""radio-image row d-flex"">

                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w3"">
                                        <input type=""radio"" name=""w-noise"" id=""w3"" class="" text-center"" onclick=""player('.track3')"">
                                        <img src=""/icons/rain (1).png"">
                                        <audio preload=""metadata"" class=""track3""");
            BeginWriteAttribute("src", " src=\"", 1768, "\"", 1780, 1);
#nullable restore
#line 43 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 1774, Chuva, 1774, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                    <span>Chuva</span>
                                </div>
                            </div>

                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w4"">
                                        <input type=""radio"" name=""w-noise"" id=""w4"" class="" text-center"" onclick=""player('.track4')"">
                                        <img src=""/icons/cascata.png"">
                                        <span>Cascata</span>
                                        <audio preload=""metadata"" class=""track4""");
            BeginWriteAttribute("src", " src=\"", 2571, "\"", 2585, 1);
#nullable restore
#line 55 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 2577, Cascata, 2577, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>

                                    </label>
                                </div>

                            </div>
                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w5"">
                                        <input type=""radio"" name=""w-noise"" id=""w5"" class="" text-center"" onclick=""player('.track5')"">
                                        <img src=""/icons/onda.png"">
                                        <span>Ondas</span>
                                        <audio preload=""metadata"" class=""track5""");
            BeginWriteAttribute("src", " src=\"", 3317, "\"", 3327, 1);
#nullable restore
#line 67 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 3323, Mar, 3323, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>

                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w6"">
                                        <input type=""radio"" name=""w-noise"" id=""w6"" class="" text-center"" onclick=""player('.track6')"">
                                        <img src=""/icons/chuveiro.png"">
                                        <span>Chuveiro</span>
                                        <audio preload=""metadata"" class=""track6""");
            BeginWriteAttribute("src", " src=\"", 4065, "\"", 4080, 1);
#nullable restore
#line 78 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 4071, Chuveiro, 4071, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>

                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w7"">
                                        <input type=""radio"" name=""w-noise"" id=""w7"" class="" text-center"" onclick=""player('.track7')"">
                                        <img src=""/icons/wind.png"">
                                        <span>Vento</span>
                                        <audio preload=""metadata"" class=""track7""");
            BeginWriteAttribute("src", " src=\"", 4811, "\"", 4823, 1);
#nullable restore
#line 89 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 4817, Vento, 4817, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>

                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w9"">
                                        <input type=""radio"" name=""w-noise"" id=""w9"" class="" text-center"" onclick=""player('.track9')"">
                                        <img src=""/icons/gravida.png"">
                                        <span>Uterino</span>
                                        <audio preload=""metadata"" class=""track9""");
            BeginWriteAttribute("src", " src=\"", 5559, "\"", 5574, 1);
#nullable restore
#line 100 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 5565, Ulterino, 5565, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>

                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w11"">
                                        <input type=""radio"" name=""w-noise"" id=""w11"" class="" text-center"" onclick=""player('.track11')"">
                                        <img src=""/icons/car (1).png"">
                                        <span>Carro</span>
                                        <audio preload=""metadata"" class=""track11""");
            BeginWriteAttribute("src", " src=\"", 6312, "\"", 6324, 1);
#nullable restore
#line 111 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 6318, Carro, 6318, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>

                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w44"">
                                        <input type=""radio"" name=""w-noise"" id=""w44"" class="" text-center"" onclick=""player('.track44')"">
                                        <img src=""/icons/aquecedor.png"">
                                        <span>Aquecedor</span>
                                        <audio preload=""metadata"" class=""track44""");
            BeginWriteAttribute("src", " src=\"", 7068, "\"", 7084, 1);
#nullable restore
#line 122 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 7074, Aquecedor, 7074, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>

                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w55"">
                                        <input type=""radio"" name=""w-noise"" id=""w55"" class="" text-center"" onclick=""player('.track55')"">
                                        <img src=""/icons/aspirador-de-po.png"">
                                        <span>Aspirador</span>
                                        <audio preload=""metadata"" class=""track55""");
            BeginWriteAttribute("src", " src=\"", 7834, "\"", 7850, 1);
#nullable restore
#line 133 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 7840, Aspirador, 7840, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>
                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w66"">
                                        <input type=""radio"" name=""w-noise"" id=""w66"" class="" text-center"" onclick=""player('.track66')"">
                                        <img src=""/icons/secador-de-cabelo.png"">
                                        <span>Secador</span>
                                        <audio preload=""metadata"" class=""track66""");
            BeginWriteAttribute("src", " src=\"", 8599, "\"", 8613, 1);
#nullable restore
#line 143 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 8605, Secador, 8605, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>
                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w77"">
                                        <input type=""radio"" name=""w-noise"" id=""w77"" class="" text-center"" onclick=""player('.track77')"">
                                        <img src=""/icons/ventilador-de-mesa.png"">
                                        <span>Ventilador</span>
                                        <audio preload=""metadata"" class=""track77""");
            BeginWriteAttribute("src", " src=\"", 9366, "\"", 9383, 1);
#nullable restore
#line 153 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 9372, Ventilador, 9372, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>
                            <div class=""col-12 col-sm-6 col-md-4 col-lg-3  mb-2 rounded-lg d-flex wrap justify-content-center"">
                                <div style=""width: 170px; position:relative;"">
                                    <label for=""w88"">
                                        <input type=""radio"" name=""w-noise"" id=""w88"" class="" text-center sd"" onclick=""player('.track88')"">
                                        <img src=""/icons/aquecedor.png"">
                                        <span>Aquecedor</span>
                                        <audio preload=""metadata"" class=""track88""");
            BeginWriteAttribute("src", " src=\"", 10129, "\"", 10147, 1);
#nullable restore
#line 163 "C:\estudos\repoRecode\greenTea\greenTea\Views\Home\Wnoise.cshtml"
WriteAttributeValue("", 10135, Nebulizador, 10135, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></audio>
                                    </label>
                                </div>
                            </div>

                        </fieldset>

                    </div>
                </div>
            </section>
        </div>    
    </div>
");
            WriteLiteral(@"<script>

    let cont = 0;
    const player = (track) => {
        const audio = document.querySelector(track);
        const pauseGeral = document.querySelectorAll(""audio"");
        for (var i = 0; i < pauseGeral.length; i++) {
            pauseGeral[i].pause();
        }
        console.log(cont);
        if (cont == 0) {
            cont = 1;
            audio.play();
        } else {
            audio.pause();
            cont = 0;
        }
        
    };
</script> 
");
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
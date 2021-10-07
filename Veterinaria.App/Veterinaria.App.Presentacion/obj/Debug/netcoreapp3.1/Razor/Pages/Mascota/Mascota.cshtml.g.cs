#pragma checksum "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b42d720239b566e2195a310fd2c63a51826ec2af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Mascota.Pages_Mascota_Mascota), @"mvc.1.0.razor-page", @"/Pages/Mascota/Mascota.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Mascota
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
#line 1 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42d720239b566e2195a310fd2c63a51826ec2af", @"/Pages/Mascota/Mascota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascota_Mascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
  
    ViewData["Title"] = "Gestión de la Mascota";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    * {
        margin: 0%;
    }

    .contenedor1 {
        display: flex;
        justify-content: space-between;

    }

    .btn-add_mascota {
        float: left;
        padding-left: 10px;

    }

    .buscar_mascota {
        float: right;
        display: flex;
        justify-content: flex-start;
        align-items: center;
    }
</style>

<div class=""text-center"">
    <h1 class=""display-4"">Gestión de la Mascota</h1>
    <p>Grupo 28 - Equipo 1 ... Conoce más nuestro proyecto en <a
            href=""https://github.com/JorgeVasquez423/VeterinariaMisionTIC2022"">GitHub</a>.</p>
</div>

<div>
    <nav>
        <h1>
            <a href=""#"">Veterinaria</a>
        </h1>
    </nav>
</div>

<div class=""container contenedor1"">
    <!-- btn agregar -->
    <div class=""btn-add_mascota"">
        <a");
            BeginWriteAttribute("href", " href=\"", 1007, "\"", 1014, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">Nuevo</a>
    </div>

    <!-- buscar -->
    <div class="" buscar_mascota "">
        <input type=""text"" class=""form-control"" placeholder=""Buscar"">
        <i class=""fas fa-search""></i>
    </div>
</div>

<!-- tabla listar -->
<div class=""container "">

    <div class=""table-responsive  "">
        <table class=""table table-striped "">
            <caption>Lista de mascotas</caption>
            <thead>
                <tr class=""bg-dark"" style="" color:white"">
                    <th scope=""col"">#</th>
                    <th scope=""col"">nombre</th>
                    <th scope=""col"">Especie Mascota</th>
                    <th scope=""col"">Raza Mascota</th>
                    <th scope=""col"">Edad Mascota</th>
                    <th scope=""col"">Opciones </th>
                </tr>
            </thead>
            <tbody>
                
");
#nullable restore
#line 79 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
                 foreach (Mascotax m in Model.listaMascotas) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
                                                                                                                    
                {
                    


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">1 </th>\r\n                        <td>");
#nullable restore
#line 85 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
                       Write(m.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 86 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
                       Write(m.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 87 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
                       Write(m.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 88 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
                       Write(m.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                        <td>
                            <button class=""btn btn-danger"">
                                <i class=""far fa-trash-alt""></i>
                            </button>
                            <button class=""btn btn-success"" data-toggle=""modal"" data-target=""#ViewModal"">
                                <i class=""far fa-eye""></i>
                            </button>
                            <button class=""btn btn-warning"" data-toggle=""modal"" data-target=""#EditModal"">
                                <i class=""far fa-edit""></i>
                            </button>
                        </td>
                    </tr>
");
#nullable restore
#line 102 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 106 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
                 for (int i = 0; i < 2; i++)
                {


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
            WriteLiteral(@"<div>

    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
        aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Crear Mascota</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
");
            WriteLiteral("                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b42d720239b566e2195a310fd2c63a51826ec2af9971", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n");
                WriteLiteral("                                <label for=\"add-Mascota\">Nombre:</label>\r\n                                <input type=\"text\" class=\"form-control\" id=\"name\" placeholder=\"Nombre\">\r\n");
                WriteLiteral("                                <label for=\"add-Mascota\">Especie:</label>\r\n                                <input type=\"text\" class=\"form-control\" id=\"Especie\" placeholder=\"Especie\">\r\n");
                WriteLiteral("                                <label for=\"add-Mascota\">Raza:</label>\r\n                                <input type=\"text\" class=\"form-control\" id=\"Raza\" placeholder=\"Raza\">\r\n");
                WriteLiteral("                                <label for=\"add-Mascota\">Edad:</label>\r\n                                <input type=\"number\" class=\"form-control\" id=\"Edad\" placeholder=\"Edad\">\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                    <button type=""button"" class=""btn btn-primary"">Guardar</button>
                </div>
            </div>
        </div>
    </div>

</div>

");
            WriteLiteral(@"<div>

    <!-- Modal -->
    <div class=""modal fade"" id=""EditModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""EditModalLabel""
        aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""EditModalLabel"">Editar Mascota</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
");
            WriteLiteral("                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b42d720239b566e2195a310fd2c63a51826ec2af13413", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n");
                WriteLiteral("                                <label for=\"add-Mascota\">Nombre:</label>\r\n                                <input type=\"text\" class=\"form-control\" id=\"name\" placeholder=\"Nombre\">\r\n");
                WriteLiteral("                                <label for=\"add-Mascota\">Especie:</label>\r\n                                <input type=\"text\" class=\"form-control\" id=\"Especie\" placeholder=\"Especie\">\r\n");
                WriteLiteral("                                <label for=\"add-Mascota\">Raza:</label>\r\n                                <input type=\"text\" class=\"form-control\" id=\"Raza\" placeholder=\"Raza\">\r\n");
                WriteLiteral("                                <label for=\"add-Mascota\">Edad:</label>\r\n                                <input type=\"number\" class=\"form-control\" id=\"Edad\" placeholder=\"Edad\">\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                    <button type=""button"" class=""btn btn-primary"">Guardar</button>
                </div>
            </div>
        </div>
    </div>

</div>

");
            WriteLiteral(@"<div>

    <!-- Modal -->
    <div class=""modal fade"" id=""ViewModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""EditModalLabel""
        aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""EditModalLabel"">Vista Mascota</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
");
            WriteLiteral("                    <div>\r\n                        <div>\r\n                            <img src=\"https://s1.eestatic.com/2020/08/26/curiosidades/mascotas/mascotas-perros-gatos_515959375_158488465_1706x960.jpg\"");
            BeginWriteAttribute("alt", "\r\n                                alt=\"", 8556, "\"", 8595, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\"");
            BeginWriteAttribute("height", " height=\"", 8610, "\"", 8619, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <h6>Nombre:</h6>
                        <h6>descripción:</h6>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                    <button type=""button"" class=""btn btn-primary"">Guardar</button>
                </div>
            </div>
        </div>
    </div>

</div>


<!-- Font awesome -->
<script src=""https://kit.fontawesome.com/5f9c3bf3c5.js"" crossorigin=""anonymous""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.MascotaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.MascotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.MascotaModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.MascotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Veterinario\Veterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7496fd266376dfcb7093a31670f609af459f324a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Veterinario.Pages_Veterinario_Veterinario), @"mvc.1.0.razor-page", @"/Pages/Veterinario/Veterinario.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Veterinario
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7496fd266376dfcb7093a31670f609af459f324a", @"/Pages/Veterinario/Veterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinario_Veterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Veterinario\Veterinario.cshtml"
  
    ViewData["Title"] = "Gestión del Veterinario";

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
        padding-left: 15px;


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
    <h1 class=""display-4"">Gestión del Veterinario</h1>
    <p>Grupo 28 - Equipo 1 ... Conoce más nuestro proyecto en <a
            href=""https://github.com/JorgeVasquez423/VeterinariaMisionTIC2022"">GitHub</a>.</p>
</div>

");
            WriteLiteral("\r\n\r\n<div class=\"container contenedor1\">\r\n    <!-- btn agregar -->\r\n    <div class=\"btn-add_mascota\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 885, "\"", 892, 0);
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
                    <th scope=""col"">Nombres</th>
                    <th scope=""col"">Apellidos</th>
                    <th scope=""col"">Edad</th>
                    <th scope=""col"">Genero</th>
                    <th scope=""col"">E-mail</th>
                    <th scope=""col"">Telefono</th>
                    <th scope=""col"">Opciones</th>




                </tr>
            </thead>
            <tbody>

");
            WriteLiteral("\r\n");
#nullable restore
#line 109 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Veterinario\Veterinario.cshtml"
                 for (int i = 0; i < 2; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">1 </th>\r\n                        <td>vet ");
#nullable restore
#line 113 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Veterinario\Veterinario.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>bb</td>
                        <td>ccc</td>
                        <td>ddd</td>
                        <td>eee</td>
                        <td>fff</td>


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
#line 133 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Veterinario\Veterinario.cshtml"


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
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Crear Veterinario</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
");
            WriteLiteral("                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7496fd266376dfcb7093a31670f609af459f324a8544", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label for=""NombreVeterinario"">Nombres</label>
                                <input type=""text"" class=""form-control"" id=""NombreVeterinario""
                                    placeholder=""Ingrese su nombre"">
                            </div>
                            <div class=""form-group"">
                                <label for=""ApellidoVeterinario"">Apellidos</label>
                                <input type=""text"" class=""form-control"" id=""ApellidoVeterinario""
                                    placeholder=""Ingrese su apellido"">
                            </div>
                            <div class=""form-group"">
                                <label for=""EdadVeterinario"">Edad</label>
                                <input type=""number"" class=""form-control"" id=""EdadVeterinario""
                                    placeholder=""Ingrese su edad"">
                            </div>
             ");
                WriteLiteral(@"               <div class=""form-group"">
                                <label for=""GeneroVeterinario"">Genero</label>
                                <input type=""text"" class=""form-control"" id=""GeneroVeterinario""
                                    placeholder=""Ingrese su Genero"">
                            </div>
                            <div class=""form-group"">
                                <label for=""EmailVeterinario"">e-mail</label>
                                <input type=""email"" class=""form-control"" id=""EmailVeterinario""
                                    placeholder=""Ingrese su e-mail"">
                            </div>
                            <div class=""form-group"">
                                <label for=""TelefonoVeterinario"">Teléfono</label>
                                <input type=""number"" class=""form-control"" id=""TelefonoVeterinario""
                                    placeholder=""Ingrese su Teléfono"">
                            </div>
                       ");
                WriteLiteral(@"     <div class=""form-group"">
                                <label for=""EspecializacionVeterinario"">Especialización</label>
                                <input type=""text"" class=""form-control"" id=""EspecializacionVeterinario""
                                    placeholder=""Ingrese su Especialización"">
                            </div>
                            <div class=""form-group"">
                                <label for=""TarjetaVeterinario"">Tarjeta Profesional</label>
                                <input type=""text"" class=""form-control"" id=""TarjetaVeterinario""
                                    placeholder=""Ingrese su Tarjeta Profesional"">
                            </div>

                            <button type=""submit"" class=""btn btn-primary"">Enviar</button>
                        ");
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
                    <h5 class=""modal-title"" id=""EditModalLabel"">Editar Veterinario</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
");
            WriteLiteral("                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7496fd266376dfcb7093a31670f609af459f324a14004", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label for=""NombreVeterinario"">Nombres</label>
                                <input type=""text"" class=""form-control"" id=""NombreVeterinario""
                                    placeholder=""Ingrese su nombre"">
                            </div>
                            <div class=""form-group"">
                                <label for=""ApellidoVeterinario"">Apellidos</label>
                                <input type=""text"" class=""form-control"" id=""ApellidoVeterinario""
                                    placeholder=""Ingrese su apellido"">
                            </div>
                            <div class=""form-group"">
                                <label for=""EdadVeterinario"">Edad</label>
                                <input type=""number"" class=""form-control"" id=""EdadVeterinario""
                                    placeholder=""Ingrese su edad"">
                            </div>
             ");
                WriteLiteral(@"               <div class=""form-group"">
                                <label for=""GeneroVeterinario"">Genero</label>
                                <input type=""text"" class=""form-control"" id=""GeneroVeterinario""
                                    placeholder=""Ingrese su Genero"">
                            </div>
                            <div class=""form-group"">
                                <label for=""EmailVeterinario"">e-mail</label>
                                <input type=""email"" class=""form-control"" id=""EmailVeterinario""
                                    placeholder=""Ingrese su e-mail"">
                            </div>
                            <div class=""form-group"">
                                <label for=""TelefonoVeterinario"">Teléfono</label>
                                <input type=""number"" class=""form-control"" id=""TelefonoVeterinario""
                                    placeholder=""Ingrese su Teléfono"">
                            </div>
                       ");
                WriteLiteral(@"     <div class=""form-group"">
                                <label for=""EspecializacionVeterinario"">Especialización</label>
                                <input type=""text"" class=""form-control"" id=""EspecializacionVeterinario""
                                    placeholder=""Ingrese su Especialización"">
                            </div>
                            <div class=""form-group"">
                                <label for=""TarjetaVeterinario"">Tarjeta Profesional</label>
                                <input type=""text"" class=""form-control"" id=""TarjetaVeterinario""
                                    placeholder=""Ingrese su Tarjeta Profesional"">
                            </div>

                            <button type=""submit"" class=""btn btn-primary"">Enviar</button>
                        ");
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
                    <h5 class=""modal-title"" id=""EditModalLabel"">Vista Veterinario</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
");
            WriteLiteral("                    <div>\r\n                        <div>\r\n                            <img src=\"https://zoovetesmipasion.com/wp-content/uploads/2017/04/veterinario-731x535.png\"");
            BeginWriteAttribute("alt", "\r\n                                alt=\"", 13121, "\"", 13160, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\"");
            BeginWriteAttribute("height", " height=\"", 13175, "\"", 13184, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <h6>Nombre:</h6>
                        <h6>Especialización:</h6>
                        <h6>numero tarjeta profecional:</h6>
                        <h6>Descripción:</h6>
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
<script src=""https://kit.fontawesome.com/5f9c3bf3c5.js"" crossorigin=""anonymous""></script>

");
            WriteLiteral("\r\n\r\n<div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

<<<<<<< HEAD
#pragma checksum "C:\GIT\MisionTIC\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29b380c3350e1e1568b0e99834a868776a146ee0"
=======
#pragma checksum "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f091012d0a9b2861cc39d4b84e41491e7730d08"
>>>>>>> master
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
<<<<<<< HEAD
#line 1 "C:\GIT\MisionTIC\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
=======
#line 1 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
>>>>>>> master
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b380c3350e1e1568b0e99834a868776a146ee0", @"/Pages/Mascota/Mascota.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f091012d0a9b2861cc39d4b84e41491e7730d08", @"/Pages/Mascota/Mascota.cshtml")]
>>>>>>> master
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascota_Mascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 3 "C:\GIT\MisionTIC\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
=======
#line 3 "D:\todo\cursos virt\MINTIC\ciclo3\programacion\proyecto veterinaria\Veterinaria\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Mascota\Mascota.cshtml"
>>>>>>> master
  
    ViewData["Title"] = "Gestión de la Mascota";

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Gestión de la Mascota</h1>\r\n    <p>Grupo 28 - Equipo 1 ... Conoce más nuestro proyecto en <a href=\"https://github.com/JorgeVasquez423/VeterinariaMisionTIC2022\">GitHub</a>.</p>\r\n</div>\r\n\r\n");
=======
            WriteLiteral(@"
<style>
    *{
    margin: 0%;
}

.contenedor1{
    display: flex;
    justify-content:space-between;
    
}
.btn-add_mascota{
   float: left;
   padding-left: 10px ;

}
.buscar_mascota{
    float: right;
    display: flex;
    justify-content:flex-start;
    align-items:center;
}
</style>

<div class=""text-center"">
    <h1 class=""display-4"">Gestión de la Mascota</h1>
    <p>Grupo 28 - Equipo 1 ... Conoce más nuestro proyecto en <a href=""https://github.com/JorgeVasquez423/VeterinariaMisionTIC2022"">GitHub</a>.</p>
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
            BeginWriteAttribute("href", " href=\"", 902, "\"", 909, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Nuevo</a>
    
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
                    <tr>
             ");
            WriteLiteral(@"           <th scope=""row"">1</th>
                        <td>Mark</td>
                        <td>Otto</td>
                        <td>mdo</td>
                        <td>mdo</td>

                        <td>
                            <button class=""btn btn-danger"">                                
                                <i class=""far fa-trash-alt""></i>
                            </button>
                            <button class=""btn btn-success"">       
                                <i class=""far fa-eye""></i>                         
                            </button>
                            <button class=""btn btn-warning"">
                                <i class=""far fa-edit""></i>                                
                            </button>
                        </td>
                    </tr>
                    <tr>
                        <th scope=""row"">2</th>
                        <td>Jacob</td>
                        <td>Thornton</td>
   ");
            WriteLiteral(@"                     <td>fat</td>
                        <td>mdo</td>

                        <td>
                            <button class=""btn btn-danger"">                                
                                <i class=""far fa-trash-alt""></i>
                            </button>
                            <button class=""btn btn-success"">       
                                <i class=""far fa-eye""></i>                         
                            </button>
                            <button class=""btn btn-warning"">
                                <i class=""far fa-edit""></i>                                
                            </button>
                        </td>
                    </tr>
                    <tr>
                        <th scope=""row"">3</th>
                        <td>Larry</td>
                        <td>the Bird</td>
                        <td>twitter</td>
                        <td>mdo</td>

                        <td>
       ");
            WriteLiteral(@"                     <button class=""btn btn-danger"">                                
                                <i class=""far fa-trash-alt""></i>
                            </button>
                            <button class=""btn btn-success"">       
                                <i class=""far fa-eye""></i>                         
                            </button>
                            <button class=""btn btn-warning"">
                                <i class=""far fa-edit""></i>                                
                            </button>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>


    </div>

<!-- Font awesome -->
    <script src=""https://kit.fontawesome.com/5f9c3bf3c5.js"" crossorigin=""anonymous""></script>");
>>>>>>> master
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

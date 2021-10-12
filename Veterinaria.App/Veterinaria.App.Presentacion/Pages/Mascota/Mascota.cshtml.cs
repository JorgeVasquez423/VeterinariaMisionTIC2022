using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Presentacion.Pages
{
    public class MascotaModel : PageModel
    {

        /* instancia obj mascota */
        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());

        /* lista de mascotas */
        //public List<Mascotax> listaMascotas = new List<Mascotax>();
        public IEnumerable<Mascota> listaMascotas = new List<Mascota>();


        /*------  */
        private readonly ILogger<MascotaModel> _logger;

        public MascotaModel(ILogger<MascotaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // add mascota a la lista
           /*  this.listaMascotas.Add( new Mascotax{
                Nombre = "Rayo",
                Especie = "Perro",
                Raza = "pitbull",
                Edad = "2"
            } ); */

            this.listaMascotas = repositorioMascota.GetMascota();
        }
    }


    /* public class Mascotax{

        public String Nombre{get;set;}
        public String Especie{get;set;}
        public String Raza{get;set;}
        public String Edad{get;set;}


    } */
}

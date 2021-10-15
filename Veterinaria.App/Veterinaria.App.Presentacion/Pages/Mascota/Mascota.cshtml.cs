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
        
        public Mascota mascotaDeEdicion;
        public String modoEdicion = "adicion";

        public Mascota mascotaConCitas;

        /*------  */
        private readonly ILogger<MascotaModel> _logger;

        public MascotaModel(ILogger<MascotaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet( int idMascota)
        {

            if (idMascota > 0)
            {
                this.mascotaDeEdicion = repositorioMascota.GetMascota(idMascota);     
                this.modoEdicion = "edicion";
                                    
            }else
            {
                this.modoEdicion ="adicion";
            }
            
            this.listaMascotas = repositorioMascota.GetMascota();
            

        }

        public void OnPostAdd(Mascota mascotaNuevo){
            repositorioMascota.addMascota (mascotaNuevo);

            //
            this.listaMascotas = repositorioMascota.GetMascota();
        }

        public void OnPostDel(int IdMascota){
            repositorioMascota.eliminarMascota (IdMascota);

            //
            this.listaMascotas = repositorioMascota.GetMascota();
        }

        public void OnPostEdit(Mascota mascotaNuevo){
            repositorioMascota.editMascota(mascotaNuevo);
            //Console.WriteLine("nombre: " + mascotaNuevo.Especie);

            //
            this.listaMascotas = repositorioMascota.GetMascota();
        }

        public int bandera = 0;
         public void OnGetMascotaConCitas(int idMascota)
        {
            

            if (idMascota > 0)
            {
                bandera = 1;
                this.mascotaConCitas = repositorioMascota.GetMascotaConCitas(idMascota);
                
            }
            else
            {
                //this.modoEdicion ="adicion";
            }
            this.listaMascotas = repositorioMascota.GetMascota();



        }

        
    }

}

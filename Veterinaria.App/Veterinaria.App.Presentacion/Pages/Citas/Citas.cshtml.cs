using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Presentacion.Page
{
    public class CitasModel : PageModel
    {
       

      /*  private readonly ILogger<CitasModel> _logger;

        public CitasModel(ILogger<CitasModel> logger)
        {
            _logger = logger;
        } */

        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());

        private static IRepositorioCita repositorioCita = new RepositorioCita(new Persistencia.AppContext());



        public Mascota mascotaConCitas;
        public IEnumerable<Mascota> listaMascotas = new List<Mascota>();


        

        /* public void OnGet(int idMascota)
        {
            
            

            
        } */
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
            /* this.listaMascotas = repositorioMascota.GetMascota(); */



        }

        public void OnPostAdd(Cita CitaNuevo){

            Console.WriteLine(CitaNuevo.Id );
            Console.WriteLine( CitaNuevo.Fecha);

            repositorioCita.addCita (CitaNuevo);
            //
            
        }

         public void OnGet(){
            this.listaMascotas = repositorioMascota.GetMascota();
            //
            
            
        }


    }
}

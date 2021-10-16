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
    public class InformesModel : PageModel
    {
        private static IRepositorioSugerenciaCuidado repositorioSugerenciaCuidado = new RepositorioSugerenciaCuidado(new Persistencia.AppContext());

        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());

        public SugerenciaCuidado sugDeEdicion;
        public IEnumerable<SugerenciaCuidado> listaSugerenciaCuidado = new List<SugerenciaCuidado>();
        public Mascota mascotaConInforme;
/*         public String modoEdicion = "adicion";
 */



        public void listar(){

            this.listaSugerenciaCuidado = repositorioSugerenciaCuidado.GetSugerenciaCuidado();


        }

        public int bandera = 0;

        public void OnGet( int idSug)
        {          
                listar();
        }
         public void OnGetMascotaConInforme(int idMascota)
        {
            

            if (idMascota > 0)
            {
                bandera = 1;
                this.mascotaConInforme = repositorioMascota.GetMascotaConInforme(idMascota);
                
            }
            else
            {
                //this.modoEdicion ="adicion";
            }
            //this.listaMascotas = repositorioMascota.GetMascota();



        }
    }
}
/* GetMascotaConInforme */
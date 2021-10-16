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
    public class VacunaModel : PageModel
    {

        private static IRepositorioVacuna repositorioVacuna = new RepositorioVacuna(new Persistencia.AppContext());

        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());


        public IEnumerable<Vacuna> listaVacunas = new List<Vacuna>();

        public Vacuna vacunaDeEdicion;

        public Mascota mascotaConVacunas;

        public String modoEdicion = "adicion";

        public void lista(){
            this.listaVacunas = repositorioVacuna.GetVacuna();
        }



        public void OnGet( int idVacuna)
        {
            if (idVacuna > 0)
            {
                this.vacunaDeEdicion = repositorioVacuna.GetVacuna(idVacuna);     
                this.modoEdicion = "edicion";
                                    
            }else
            {
                this.modoEdicion ="adicion";
            }
            
            lista();
        }
        public void OnPostAdd(Vacuna VacunaNuevo){
            repositorioVacuna.addVacuna (VacunaNuevo);

            //
            lista();
        }

        public void OnPostDel(int IdMascota){
            repositorioVacuna.eliminarVacuna (IdMascota);

            //
            lista();
        }

        public void OnPostEdit(Vacuna VacunaNuevo){
            repositorioVacuna.editVacuna(VacunaNuevo);
            //Console.WriteLine("nombre: " + VacunaNuevo.Especie);

            //
            lista();
        }

        public int bandera = 0;
        public void OnGetMascotaConVacunas(int idMascota)
        {
            

            if (idMascota > 0)
            {
                bandera = 1;
                this.mascotaConVacunas = repositorioMascota.GetMascotaConVacuna(idMascota);
                
            }
            else
            {
                //this.modoEdicion ="adicion";
            }
            //this.listaMascotas = repositorioMascota.GetMascota();



        }
    }
}

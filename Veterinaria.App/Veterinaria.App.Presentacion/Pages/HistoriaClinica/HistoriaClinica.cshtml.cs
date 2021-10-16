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
    public class HistoriaClinicaModel : PageModel
    {
        private static IRepositorioHistoriaClinica repositorioHistoriaClinica = new RepositorioHistoriaClinica(new Persistencia.AppContext());
        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());


        public IEnumerable<HistoriaClinica> listaHistoriaClinica = new List<HistoriaClinica>();
        public IEnumerable<Mascota> listaMascotas = new List<Mascota>();



        public void listar()
        {
            this.listaHistoriaClinica = repositorioHistoriaClinica.GetHistoriaClinica();
            this.listaMascotas = repositorioMascota.GetMascota();

        }

        public void OnGet()
        {
            listar();
            
        }
    }
}

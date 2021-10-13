using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Presentacion.Pages
{
    public class CuidadorModel : PageModel
    {
        /*  */
        private static IRepositorioCuidador repositorioCuidador = new RepositorioCuidador(new Persistencia.AppContext());

        public IEnumerable<Cuidador> listaCuidadores = new List<Cuidador>();
        
        public Cuidador CuidadorDeEdicion;
        public String modoEdicion = "adicion";


        /*  */


        private readonly ILogger<CuidadorModel> _logger;

        public CuidadorModel(ILogger<CuidadorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int idCuidador)
        {
            if (idCuidador > 0)
            {
                this.CuidadorDeEdicion = repositorioCuidador.GetCuidador(idCuidador);     
                this.modoEdicion = "edicion";
                                    
            }else
            {
                this.modoEdicion ="adicion";
            }
            
            this.listaCuidadores = repositorioCuidador.GetCuidadores();
        }
        public void OnPostAdd(Cuidador CuidadorNuevo){
            repositorioCuidador.addCuidador (CuidadorNuevo);

            //
            this.listaCuidadores = repositorioCuidador.GetCuidadores();
        }

        public void OnPostDel(int IdCuidador){
            repositorioCuidador.eliminarCuidador (IdCuidador);

            //
            this.listaCuidadores = repositorioCuidador.GetCuidadores();
        }

        public void OnPostEdit(Cuidador CuidadorNuevo){
            repositorioCuidador.editCuidador(CuidadorNuevo);
            //Console.WriteLine("nombre: " + CuidadorNuevo.Especie);

            //
            this.listaCuidadores = repositorioCuidador.GetCuidadores();
        }
    }
}

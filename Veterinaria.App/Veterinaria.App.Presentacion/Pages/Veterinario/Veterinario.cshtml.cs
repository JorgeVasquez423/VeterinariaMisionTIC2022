using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

/*  */
//using Veterinaria.App.Persistencia;
//using Veterinaria.App.Dominio;



namespace Veterinaria.App.Presentacion.Pages
{
    public class VeterinarioModel : PageModel
    {
        private readonly ILogger<VeterinarioModel> _logger;

        public VeterinarioModel(ILogger<VeterinarioModel> logger)
        {
            _logger = logger;
        }

        /*  */
        //private readonly IRepositorioVeterinario repoVeterinarios;

        //public IEnumerable<Veterinario> Veterinarios {get; set;}


                //constructor
        /* public VeterinarioModel(IRepositorioVeterinario repoVeterinarios){

            this.repoVeterinarios = repoVeterinarios;

        } */

        public void OnGet()
        {
            //Veterinarios=repoVeterinarios.GetAll();
        }
    }
}

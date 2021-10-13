using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

/*  */
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;



namespace Veterinaria.App.Presentacion.Pages
{
    public class VeterinarioModel : PageModel
    {

        /* instacia de objeto veterinario */
        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        /* 10 oct */

        public IEnumerable<Veterinario> listaVeterinario = new List<Veterinario>();

        public Veterinario veterinarioDeEdicion;
        public String modoEdicion = "adicion";


        /* 10 oct */

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

        public int i = 0;

        public void OnGet(int idVeterinario)
        {
            Console.WriteLine("id: "+ idVeterinario);

            if (idVeterinario > 0)
            {
                this.veterinarioDeEdicion = repositorioVeterinario.GetVeterinario(idVeterinario);     
                this.modoEdicion = "edicion";
                                    
            }else
            {
                this.modoEdicion ="adicion";
            }
            
            this.listaVeterinario = repositorioVeterinario.GetVeterinario();
            
        }

        public void OnPostAdd(Veterinario veterinarioNuevo){
            repositorioVeterinario.addVeterinario(veterinarioNuevo);

            //
            this.listaVeterinario = repositorioVeterinario.GetVeterinario();
        }
        public void OnPostDel(int idVeterinario){
            repositorioVeterinario.eliminarVeterinario (idVeterinario);

            //
            this.listaVeterinario = repositorioVeterinario.GetVeterinario();
        }
        public void OnPostEdit(Veterinario veterinarioNuevo){
            repositorioVeterinario.editVeterinario(veterinarioNuevo);
            //Console.WriteLine("nombre: " + mascotaNuevo.Especie);

            //
            this.listaVeterinario = repositorioVeterinario.GetVeterinario();

        }
    }
}

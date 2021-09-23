using System;
using Veterinaria.App.Dominio;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{


    //este repositorio es como el modelo que se manejo en java mvc

    public class RepositorioVeterinario : IRepositorioVeterinario{
        private readonly AppContext appContext;

        //constructor

        public RepositorioVeterinario(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        public Veterinario addVeterinario(Veterinario veterinario){

            var veterinarioAdicionado = this.appContext.Veterinarios.Add(veterinario);
            this.appContext.SaveChanges();

            return veterinarioAdicionado.Entity;
        }

        public Veterinario editVeterinario(Veterinario veterinario){
            return null;

        }

        public void eliminarVeterinario(int idVeterinario){
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);

            if(veterinarioEncontrado == null){
                //return null;
                //var x=5;
                return ;
            }
            else
            {
                this.appContext.Veterinarios.Remove(veterinarioEncontrado);
                this.appContext.SaveChanges();
            }

        }
        public Veterinario GetVeterinario(int idVeterinario){
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);

            if(veterinarioEncontrado != null){
                return veterinarioEncontrado;
            }
            return null;

        }
        public IEnumerable<Veterinario> GetVeterinario(){
            return null;

        }



    }
}
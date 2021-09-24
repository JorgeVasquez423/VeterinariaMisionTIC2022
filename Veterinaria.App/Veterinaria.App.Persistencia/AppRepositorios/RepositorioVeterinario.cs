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
            Console.WriteLine("veterinario agregado");

            return veterinarioAdicionado.Entity;
        }

        public Veterinario editVeterinario(Veterinario veterinarioNuevo){
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinarioNuevo.Id);

            if (veterinarioEncontrado != null){

                veterinarioEncontrado.Nombre  = veterinarioNuevo.Nombre;
                veterinarioEncontrado.Telefono  = veterinarioNuevo.Telefono;
                veterinarioEncontrado.Edad  = veterinarioNuevo.Edad;
                veterinarioEncontrado.Correo  = veterinarioNuevo.Correo;
                veterinarioEncontrado.Contraseña  = veterinarioNuevo.Contraseña;
                veterinarioEncontrado.FechaRegistro  = veterinarioNuevo.FechaRegistro;
                veterinarioEncontrado.Especializacion  = veterinarioNuevo.Especializacion;
                veterinarioEncontrado.TarjetaProfecional  = veterinarioNuevo.TarjetaProfecional;
                this.appContext.SaveChanges();

            }
            
            return null;

        }

        public void eliminarVeterinario(int idVeterinario){
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);

            if(veterinarioEncontrado == null){
                //return null;
                //var x=5;
                Console.WriteLine("no existe el id del veterinario que desea eliminar");
                return ;
            }
            else
            {
                this.appContext.Veterinarios.Remove(veterinarioEncontrado);
                this.appContext.SaveChanges();
                Console.WriteLine("Veterinario Eliminado");
            }

        }
        public Veterinario GetVeterinario(int idVeterinario){
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);

            if(veterinarioEncontrado != null){
                return veterinarioEncontrado;
            }else
            {
                Console.WriteLine("veterinario no encontrado");
                return null;                
            }

        }
        public IEnumerable<Veterinario> GetVeterinario(){
            return null;

        }



    }
}
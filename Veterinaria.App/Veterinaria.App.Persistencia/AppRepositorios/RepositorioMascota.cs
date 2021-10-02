using System;
using Veterinaria.App.Dominio;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{

    

    public class RepositorioMascota : IRepositorioMascota{
        private readonly AppContext appContext;

        //constructor
        public RepositorioMascota (AppContext appContextParam){
            this.appContext = appContextParam;
        }

        public Mascota addMascota(Mascota mascota){

            var mascotaAdicionado = this.appContext.Mascotas.Add(mascota);
            this.appContext.SaveChanges();

            Console.WriteLine("Macota "+ mascota.Nombre +" agregada");

            return mascotaAdicionado.Entity;

        }

        public Mascota editMascota(Mascota MascotaNuevo){
            var mascotaEncontrado = this.appContext.Mascotas.FirstOrDefault(m => m.Id == MascotaNuevo.Id);
            if (mascotaEncontrado != null){

                mascotaEncontrado.Nombre  = MascotaNuevo.Nombre;                
                mascotaEncontrado.Edad  = MascotaNuevo.Edad;
                mascotaEncontrado.FechaRegistro  = MascotaNuevo.FechaRegistro;
                this.appContext.SaveChanges();
                Console.WriteLine("la mascota "+ MascotaNuevo.Nombre + " fue modificada");

            }
            
            return null;
        }
        public void eliminarMascota(int idMascota){

            var mascotaEncontrado = this.appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);

            if(mascotaEncontrado == null){
                Console.WriteLine("no existe el id de la Mascota que desea eliminar");
                return ;
            }else
            {
                this.appContext.Mascotas.Remove(mascotaEncontrado);
                this.appContext.SaveChanges();
                Console.WriteLine("Mascota Eliminada");
            }

        }
        public Mascota GetMascota(int idMascota){
            var mascotaEncontrado = this.appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);

            if(mascotaEncontrado != null){
                return mascotaEncontrado;
            }
            return null;
            
        }
        public IEnumerable<Mascota> GetMascota(){
            return null;

        }

    }


}

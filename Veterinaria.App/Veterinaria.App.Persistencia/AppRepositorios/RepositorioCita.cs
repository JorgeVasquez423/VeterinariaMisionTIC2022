using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly AppContext appContext;

        public RepositorioCita(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        /*  */
        public Cita addCita(Cita cita){
            var citaAdicionado = this.appContext.Citas.Add(cita);
            this.appContext.SaveChanges();
            Console.WriteLine("Cita agregado");

            return citaAdicionado.Entity;
             
         }
        public Cita editCita(Cita citaNuevo){
            var citaEncontrado =
                this
                    .appContext
                    .Citas
                    .FirstOrDefault(v => v.Id == citaNuevo.Id);

            if (citaEncontrado != null)
            {                
                citaEncontrado.Fecha = citaNuevo.Fecha;
                
                this.appContext.SaveChanges();
            }

            return null;
        }
        public void eliminarCita(int idCita){
            var citaEncontrado =
                this
                    .appContext
                    .Citas
                    .FirstOrDefault(v => v.Id == idCita);

            if (citaEncontrado == null)
            {
                //return null;
                //var x=5;
                Console
                    .WriteLine("no existe el id de la cita que desea eliminar");
                return;
            }
            else
            {
                this.appContext.Citas.Remove(citaEncontrado);
                this.appContext.SaveChanges();
                Console.WriteLine("Cita Eliminado");
            }
        }
        public Cita GetCita(int idCita){
            var citaEncontrado =
                this
                    .appContext
                    .Citas
                    .FirstOrDefault(v => v.Id == idCita);

            if (citaEncontrado != null)
            {
                return citaEncontrado;
            }
            else
            {
                Console.WriteLine("Cita no encontrada");
                return null;
            }
        }
        public IEnumerable<Cita> GetCita(){
            return null;
        }
        /*  */


        
    }
}
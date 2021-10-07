using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioVacuna : IRepositorioVacuna
    {
        private readonly AppContext appContext;

        public RepositorioVacuna(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        /*  */

        public Vacuna addVacuna(Vacuna vacuna){
            var vacunaAdicionado = this.appContext.Vacunas.Add(vacuna);
            this.appContext.SaveChanges();
            Console.WriteLine("Cuidador agregado");

            return vacunaAdicionado.Entity;
        }
        public Vacuna editVacuna(Vacuna vacunaNuevo){
            var vacunaEncontrado =
                this
                    .appContext
                    .Vacunas
                    .FirstOrDefault(v => v.Id == vacunaNuevo.Id);

            if (vacunaEncontrado != null)
            {
                vacunaEncontrado.Codigo = vacunaNuevo.Codigo;
                vacunaEncontrado.Nombre = vacunaNuevo.Nombre;
                
                this.appContext.SaveChanges();
            }

            return null;
        }
        public void eliminarVacuna(int idVacuna){
            var vacunaEncontrado =
                this
                    .appContext
                    .Vacunas
                    .FirstOrDefault(v => v.Id == idVacuna);

            if (vacunaEncontrado == null)
            {
                //return null;
                //var x=5;
                Console
                    .WriteLine("no existe el id de la Vacuna que desea eliminar");
                return;
            }
            else
            {
                this.appContext.Vacunas.Remove(vacunaEncontrado);
                this.appContext.SaveChanges();
                Console.WriteLine("Vacuna Eliminada");
            }
        }
        public Vacuna GetVacuna(int idVacuna){
            var vacunaEncontrado =
                this
                    .appContext
                    .Vacunas
                    .FirstOrDefault(v => v.Id == idVacuna);

            if (vacunaEncontrado != null)
            {
                return vacunaEncontrado;
            }
            else
            {
                Console.WriteLine("Cuidador no encontrado");
                return null;
            }
        }
        public IEnumerable<Vacuna> GetVacuna(){
            return null;
        }

        /*  */

        
    }
}
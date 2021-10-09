using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext appContext;

        public RepositorioHistoriaClinica(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        /*  */

        public HistoriaClinica addHistoriaClinica(HistoriaClinica historiaClinica){
            var historiaClinicaAdicionado = this.appContext.HistoriaClinicas.Add(historiaClinica);
            this.appContext.SaveChanges();
            Console.WriteLine("Historia Clinica agregada");

            return historiaClinicaAdicionado.Entity;        }
        public HistoriaClinica editHistoriaClinica(HistoriaClinica historiaClinicaNuevo){
            var historiaClinicaEncontrado =
                this
                    .appContext
                    .HistoriaClinicas
                    .FirstOrDefault(v => v.Id == historiaClinicaNuevo.Id);

            if (historiaClinicaEncontrado != null)
            {
                
                historiaClinicaEncontrado.FechaRegistro = historiaClinicaNuevo.FechaRegistro;
                historiaClinicaEncontrado.Descripcion = historiaClinicaNuevo.Descripcion;
                historiaClinicaEncontrado.Vacunacion = historiaClinicaNuevo.Vacunacion;

                this.appContext.SaveChanges();
            }

            return null;
        }
        public void eliminarHistoriaClinica(int idHistoriaClinica){
            var historiaClinicaEncontrado =
                this
                    .appContext
                    .HistoriaClinicas
                    .FirstOrDefault(v => v.Id == idHistoriaClinica);

            if (historiaClinicaEncontrado == null)
            {
                //return null;
                //var x=5;
                Console
                    .WriteLine("no existe el id de la Historia Clinica que desea eliminar");
                return;
            }
            else
            {
                this.appContext.HistoriaClinicas.Remove(historiaClinicaEncontrado);
                this.appContext.SaveChanges();
                Console.WriteLine("Cuidador Eliminado");
            }
        }
        public HistoriaClinica GetHistoriaClinica(int idHistoriaClinica){
            var historiaClinicaEncontrado =
                this
                    .appContext
                    .HistoriaClinicas
                    .FirstOrDefault(v => v.Id == idHistoriaClinica);

            if (historiaClinicaEncontrado != null)
            {
                return historiaClinicaEncontrado;
            }
            else
            {
                Console.WriteLine("Historia Clinica no encontrado");
                return null;
            }
        }
        public IEnumerable<HistoriaClinica> GetHistoriaClinica(){
            return null;
        }

        /*  */

        
    }
}
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
            return null;
             
         }
        public Cita editCita(Cita cita){
            return null;
        }
        public void eliminarCita(int cita){
            return ;
        }
        public Cita GetCita(int cita){
            return null;
        }
        public IEnumerable<Cita> GetCita(){
            return null;
        }
        /*  */


        
    }
}
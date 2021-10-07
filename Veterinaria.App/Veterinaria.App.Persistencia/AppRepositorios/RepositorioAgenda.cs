using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioAgenda : IRepositorioAgenda
    {
        private readonly AppContext appContext;

        public RepositorioAgenda(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        /*  */
        public Agenda addAgenda(Agenda agenda){
            return null;


        }
        public Agenda editAgenda(Agenda agenda){
            return null;


        }
        public void eliminarAgenda(int agenda){
            return ;


        }
        public Agenda GetAgenda(int agenda){
            return null;


        }
        public IEnumerable<Agenda> GetAgenda(){
            return null;


        }

        
    }
}
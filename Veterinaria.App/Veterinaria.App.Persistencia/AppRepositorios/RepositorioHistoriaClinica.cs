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
            return null;
        }
        public HistoriaClinica editHistoriaClinica(HistoriaClinica historiaClinica){
            return null;
        }
        public void eliminarHistoriaClinica(int historiaClinica){
            return ;
        }
        public HistoriaClinica GetHistoriaClinica(int historiaClinica){
            return null;
        }
        public IEnumerable<HistoriaClinica> GetHistoriaClinica(){
            return null;
        }

        /*  */

        
    }
}
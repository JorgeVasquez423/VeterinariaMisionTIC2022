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
            return null;
        }
        public Vacuna editVacuna(Vacuna vacuna){
            return null;
        }
        public void eliminarVacuna(int vacuna){
            return ;
        }
        public Vacuna GetVacuna(int vacuna){
            return null;
        }
        public IEnumerable<Vacuna> GetVacuna(){
            return null;
        }

        /*  */

        
    }
}
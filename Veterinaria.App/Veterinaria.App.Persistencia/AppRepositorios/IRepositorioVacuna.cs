using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioVacuna {

        
        
        Vacuna addVacuna(Vacuna vacuna);
        Vacuna editVacuna(Vacuna vacuna);
        void eliminarVacuna(int vacuna);
        Vacuna GetVacuna(int vacuna);
        IEnumerable<Vacuna> GetVacuna();


        
    }
}
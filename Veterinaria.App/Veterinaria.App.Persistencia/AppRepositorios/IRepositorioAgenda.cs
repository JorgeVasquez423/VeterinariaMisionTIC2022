using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioAgenda {

        
        
        Agenda addAgenda(Agenda agenda);
        Agenda editAgenda(Agenda agenda);
        void eliminarAgenda(int agenda);
        Agenda GetAgenda(int agenda);
        IEnumerable<Agenda> GetAgenda();


        
    }
}
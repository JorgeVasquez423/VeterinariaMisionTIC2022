using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioHistoriaClinica {

        
        
        HistoriaClinica addHistoriaClinica(HistoriaClinica historiaClinica);
        HistoriaClinica editHistoriaClinica(HistoriaClinica historiaClinica);
        void eliminarHistoriaClinica(int historiaClinica);
        HistoriaClinica GetHistoriaClinica(int historiaClinica);
        IEnumerable<HistoriaClinica> GetHistoriaClinica();


        
    }
}
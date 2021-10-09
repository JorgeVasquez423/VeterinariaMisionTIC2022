using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioCita {

        
        
        Cita addCita(Cita cita);
        Cita editCita(Cita cita);
        void eliminarCita(int cita);
        Cita GetCita(int cita);
        IEnumerable<Cita> GetCita();


        
    }
}
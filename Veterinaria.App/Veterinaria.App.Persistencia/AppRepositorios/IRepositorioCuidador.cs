using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioCuidador
    {
        Cuidador addCuidador(Cuidador cuidador);
        Cuidador editCuidador(Cuidador cuidador);
        void eliminarCuidador(int idCuidador);
        Cuidador GetCuidador(int idCuidador);
        IEnumerable<Cuidador> GetCuidadores();

    }
}
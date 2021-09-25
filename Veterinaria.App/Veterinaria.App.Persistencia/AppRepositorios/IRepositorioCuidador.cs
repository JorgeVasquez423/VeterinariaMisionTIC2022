using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioCuidador
    {
        public Cuidador addCuidador(Cuidador cuidador);
        public Cuidador editCuidador(Cuidador cuidador);
        public void eliminarCuidador(int idCuidador);
        public Cuidador GetCuidador(int idCuidador);
        public IEnumerable<Cuidador> GetCuidadores();

    }
}
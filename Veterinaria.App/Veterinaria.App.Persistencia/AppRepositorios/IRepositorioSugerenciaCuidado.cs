using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioSugerenciaCuidado
    {
        SugerenciaCuidado addSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        SugerenciaCuidado editSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        void eliminarSugerenciaCuidado(int idSugerenciaCuidado);
        SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado);
        IEnumerable<SugerenciaCuidado> GetSugerenciaCuidado();

    }
}
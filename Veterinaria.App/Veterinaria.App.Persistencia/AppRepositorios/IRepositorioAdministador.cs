using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioAdministador {

        
        
        Administrador addAdministrador(Administrador administrador);
        Administrador editAdministrador(Administrador administrador);
        void eliminarAdministrador(int administrador);
        Administrador GetAdministrador(int administrador);
        IEnumerable<Administrador> GetAdministrador();


        
    }
}
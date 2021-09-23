//interfaz repositorio veterinario
using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioVeterinario{
        
        Veterinario addVeterinario(Veterinario veterinario);
        Veterinario editVeterinario(Veterinario veterinario);
        void eliminarVeterinario(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);
        IEnumerable<Veterinario> GetVeterinario();


        
    }
}
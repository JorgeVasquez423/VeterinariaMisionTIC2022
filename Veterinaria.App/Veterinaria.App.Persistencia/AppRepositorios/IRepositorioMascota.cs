using Veterinaria.App.Dominio;
using System;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioMascota {

        
        
        Mascota addMascota(Mascota mascota);
        Mascota editMascota(Mascota mascota);
        void eliminarMascota(int mascota);
        Mascota GetMascota(int mascota);
        IEnumerable<Mascota> GetMascota();
        Mascota GetMascotaConCitas(int idMascota);
        Mascota GetMascotaConVacuna(int idMascota);
        Mascota GetMascotaConInforme(int idMascota);
        IEnumerable<Mascota> GetMascotaConCitasAll();


        

        
    }
}
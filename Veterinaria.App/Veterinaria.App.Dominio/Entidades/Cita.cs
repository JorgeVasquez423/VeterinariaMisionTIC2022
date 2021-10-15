using System;

namespace  Veterinaria.App.Dominio
{
    public class Cita
    {
        public int Id{get;set;}
        public DateTime Fecha {get;set;}

        public Mascota Mascota {get;set;}

        
    }
    
}
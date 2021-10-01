using System;

namespace  Veterinaria.App.Dominio
{
    public class Mascota
    {
        public int Id{get;set;}
        public String Nombre {get;set;}
        public String Especie {get;set;}
        public String Raza {get;set;}

        public int Edad {get;set;}
        public DateTime FechaRegistro {get;set;}
        
    }
    
}
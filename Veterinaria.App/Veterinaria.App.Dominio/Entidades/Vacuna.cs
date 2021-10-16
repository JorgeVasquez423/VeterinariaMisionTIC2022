using System;
using System.Collections.Generic;


namespace  Veterinaria.App.Dominio
{
    public class Vacuna
    {
        public int Id{get;set;}
        public String Codigo {get;set;}
        public String Nombre {get;set;}
        public List<Mascota> Mascotas {get;set;}


    }
    
}
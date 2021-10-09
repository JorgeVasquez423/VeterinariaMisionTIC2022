using System;

namespace  Veterinaria.App.Dominio
{
    public class HistoriaClinica
    {
        public int Id{get;set;}
        public DateTime FechaRegistro {get;set;}

        public String Descripcion {get;set;}
        public Boolean Vacunacion {get;set;}
        
    }
    
}
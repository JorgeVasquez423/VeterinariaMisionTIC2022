using System;
using System.Collections.Generic;


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

        public Cuidador Cuidador {get;set;}

        public HistoriaClinica HistoriaClinica {get;set;}


        /* la mascota tiene una lista de citas  */
        public List<Cita> Citas {get; set;}

        public List<Vacuna> Vacunas {get; set;}

        public List<SugerenciaCuidado> SugerenciaCuidados {get; set;}


        public int CuidadorId {get;set;}


        
    }
    
}
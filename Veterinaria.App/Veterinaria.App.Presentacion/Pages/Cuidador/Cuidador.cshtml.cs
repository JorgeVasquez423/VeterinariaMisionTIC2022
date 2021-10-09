using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Veterinaria.App.Presentacion.Pages
{
    public class CuidadorModel : PageModel
    {
        private readonly ILogger<CuidadorModel> _logger;

        public CuidadorModel(ILogger<CuidadorModel> logger)
        {
            _logger = logger;
        }

        public List<Cuidadorx> listaCuidadores = new List<Cuidadorx>();

        public void OnGet()
        {
            this.listaCuidadores.Add( new Cuidadorx {
                Nombre = "Juan", Telefono = "310", Edad = 38, 
                Direccion = "Calle 45 #25 - 78", Correo = "juan@gmail.com",
                DireccionTrabajo = "Avenida Simón Bolivar #98 - 101" 
            });

            this.listaCuidadores.Add( new Cuidadorx {
                Nombre = "Jorge", Telefono = "315", Edad = 38, 
                Direccion = "Carrera 73 #22 - 118", Correo = "jorge@gmail.com",
                DireccionTrabajo = "Avenida Simón Bolivar #98 - 101" 
            });

            this.listaCuidadores.Add( new Cuidadorx {
                Nombre = "Sandro", Telefono = "321", Edad = 38, 
                Direccion = "Calle 10 #47A - 02", Correo = "sandro@gmail.com",
                DireccionTrabajo = "Avenida Simón Bolivar #98 - 101" 
            });

            this.listaCuidadores.Add( new Cuidadorx {
                Nombre = "Sandro", Telefono = "321", Edad = 38, 
                Direccion = "Calle 10 #47A - 02", Correo = "sandro@gmail.com",
                DireccionTrabajo = "Avenida Simón Bolivar #98 - 101" 
            });
        }
    }

    public class Cuidadorx {

        public String Nombre {get;set;}
        public String Telefono {get;set;}
        public int Edad {get;set;}
        public String Direccion {get;set;}
        public String Correo {get;set;}
        public String Contraseña {get;set;}
        public String DireccionTrabajo { get; set; }
        
    }
}

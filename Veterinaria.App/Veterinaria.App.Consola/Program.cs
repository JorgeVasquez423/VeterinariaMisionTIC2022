using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {

        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            addVeterinario();
        }

        private static void addVeterinario(){

            Veterinario veterinario = new Veterinario {

                Nombre ="Miguel Pasaje",
                Telefono = "12345655",
                Edad = 22,
                Direccion = "cra 26 # 12-65",
                Correo = "123@veterinario.com",
                Contraseña = " 123",
                FechaRegistro = new DateTime(2021,09,21),
                Especializacion = "asdf",
                TarjetaProfecional = "123486",
            };

            repositorioVeterinario.addVeterinario(veterinario);


        }
    }
}

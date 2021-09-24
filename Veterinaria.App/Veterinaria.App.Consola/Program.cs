using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {

        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioAdministador repositorioAdmin = new RepositorioAdministador(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* veterinario*/
            //addVeterinario();
            //BuscarVeterinario(7);
            //EditVeterinario(2);
            //eliminarVeterinario(4);




            /*admin*/
            //addAdmin();
            //eliminarAdministrador(5);
            //BuscarAdministrador(3);
            //EditAdministrador(3);

        }

        /*--------------------------------*/
        /* crud Veterinario*/
        /*--------------------------------*/

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

        /*--------------------------------*/

        private static void eliminarVeterinario(int idVeterinario){
            repositorioVeterinario.eliminarVeterinario(idVeterinario);

        }
        /*--------------------------------*/

        private static void BuscarVeterinario(int idVeterinario){
            var veterinarioEncontrado = repositorioVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine("veterinario --> nombre: " + veterinarioEncontrado.Nombre);

        }

        /*--------------------------------*/


        private static void EditVeterinario(int idVeterinario){

            Veterinario veterinario = new Veterinario {

                Id = idVeterinario,
                Nombre ="Miguel Pasaje",
                Telefono = "12345655",
                Edad = 22,
                Direccion = "cra 26 # 12-65",
                Correo = "123@veterinario.com",
                Contraseña = " 123",
                FechaRegistro = new DateTime(2021,09,21),
                Especializacion = "anestesiologo",
                TarjetaProfecional = "123486",
            };

            repositorioVeterinario.editVeterinario(veterinario);

        
        }

        /*--------------------------------*/
        /* crud administrador*/
        /*--------------------------------*/

        public static void addAdmin(){

            Administrador admin = new Administrador {

                Nombre ="Miguel Pasaje",
                Telefono = "12345655",
                Edad = 22,
                Direccion = "cra 26 # 12-65",
                Correo = "123@veterinario.com",
                Contraseña = " 123#$%",
                FechaRegistro = new DateTime(2021,09,21),
                Cargo = "Administrador",
                    
            };
               
            repositorioAdmin.addAdministrador(admin);
        }

        /*--------------------------------*/

        private static void eliminarAdministrador(int idadmin){
            repositorioAdmin.eliminarAdministrador(idadmin);

        }
        /*--------------------------------*/

        private static void BuscarAdministrador(int idadmin){
            var adminEncontrado = repositorioAdmin.GetAdministrador(idadmin);
            Console.WriteLine("Administrador --> nombre: " + adminEncontrado.Nombre);

        }

        /*--------------------------------*/


        private static void EditAdministrador(int idadmin){

            Administrador admin = new Administrador {

                Id = idadmin,
                Nombre ="Miguel Pasaje",
                Telefono = "12345655",
                Edad = 22,
                Direccion = "cra 26 # 12-65",
                Correo = "MP@admin.com",
                Contraseña = " 123#$%123",
                FechaRegistro = new DateTime(2021,09,21),
                Cargo = "Administrador Jefe",
                    
            };
               
            repositorioAdmin.editAdministrador(admin);

        
        }



    }
}

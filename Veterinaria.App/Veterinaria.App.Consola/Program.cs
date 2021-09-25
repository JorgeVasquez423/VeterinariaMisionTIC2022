using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {
        private static IRepositorioVeterinario
            repositorioVeterinario =
                new RepositorioVeterinario(new Persistencia.AppContext());

        private static IRepositorioAdministador
            repositorioAdmin =
                new RepositorioAdministador(new Persistencia.AppContext());

        private static IRepositorioCuidador
            repositorioCuidador =
                new RepositorioCuidador(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutado correctamente!");

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

            /*Cuidador*/
            addCuidador();
            //eliminarCuidador(5);
            //BuscarCuidador(3);
            //EditCuidador(3);
        }

        /*--------------------------------*/
        /* crud Veterinario*/
        /*--------------------------------*/
        private static void addVeterinario()
        {
            Veterinario veterinario =
                new Veterinario {
                    Nombre = "Miguel Pasaje",
                    Telefono = "12345655",
                    Edad = 22,
                    Direccion = "cra 26 # 12-65",
                    Correo = "123@veterinario.com",
                    Contraseña = " 123",
                    FechaRegistro = new DateTime(2021, 09, 21),
                    Especializacion = "asdf",
                    TarjetaProfecional = "123486"
                };

            repositorioVeterinario.addVeterinario (veterinario);
        }

        /*--------------------------------*/
        private static void eliminarVeterinario(int idVeterinario)
        {
            repositorioVeterinario.eliminarVeterinario (idVeterinario);
        }

        /*--------------------------------*/
        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado =
                repositorioVeterinario.GetVeterinario(idVeterinario);
            Console
                .WriteLine("veterinario --> nombre: " +
                veterinarioEncontrado.Nombre);
        }

        /*--------------------------------*/
        private static void EditVeterinario(int idVeterinario)
        {
            Veterinario veterinario =
                new Veterinario {
                    Id = idVeterinario,
                    Nombre = "Miguel Pasaje",
                    Telefono = "12345655",
                    Edad = 22,
                    Direccion = "cra 26 # 12-65",
                    Correo = "123@veterinario.com",
                    Contraseña = " 123",
                    FechaRegistro = new DateTime(2021, 09, 21),
                    Especializacion = "anestesiologo",
                    TarjetaProfecional = "123486"
                };

            repositorioVeterinario.editVeterinario (veterinario);
        }

        /*--------------------------------*/
        /* crud administrador*/
        /*--------------------------------*/
        public static void addAdmin()
        {
            Administrador admin =
                new Administrador {
                    Nombre = "Miguel Pasaje",
                    Telefono = "12345655",
                    Edad = 22,
                    Direccion = "cra 26 # 12-65",
                    Correo = "123@veterinario.com",
                    Contraseña = " 123#$%",
                    FechaRegistro = new DateTime(2021, 09, 21),
                    Cargo = "Administrador"
                };

            repositorioAdmin.addAdministrador (admin);
        }

        /*--------------------------------*/
        private static void eliminarAdministrador(int idadmin)
        {
            repositorioAdmin.eliminarAdministrador (idadmin);
        }

        /*--------------------------------*/
        private static void BuscarAdministrador(int idadmin)
        {
            var adminEncontrado = repositorioAdmin.GetAdministrador(idadmin);
            Console
                .WriteLine("Administrador --> nombre: " +
                adminEncontrado.Nombre);
        }

        /*--------------------------------*/
        private static void EditAdministrador(int idadmin)
        {
            Administrador admin =
                new Administrador {
                    Id = idadmin,
                    Nombre = "Miguel Pasaje",
                    Telefono = "12345655",
                    Edad = 22,
                    Direccion = "cra 26 # 12-65",
                    Correo = "MP@admin.com",
                    Contraseña = " 123#$%123",
                    FechaRegistro = new DateTime(2021, 09, 21),
                    Cargo = "Administrador Jefe"
                };

            repositorioAdmin.editAdministrador (admin);
        }

        /*--------------------------------*/
        /* CRUD Cuidador*/
        /*--------------------------------*/
        private static void addCuidador()
        {
            Cuidador cuidador =
                new Cuidador {
                    Nombre = "Jorge Vasquez",
                    Telefono = "3587469",
                    Edad = 40,
                    Direccion = "Calle 66 # 45-65",
                    Correo = "12356@cuidador.com",
                    Contraseña = "12356",
                    FechaRegistro = new DateTime(2021, 09, 24),
                    DireccionTrabajo = "Cra 154 # 56-182"
                };

            repositorioCuidador.addCuidador (cuidador);
        }

        /*--------------------------------*/
        private static void eliminarCuidador(int idCuidador)
        {
            repositorioCuidador.eliminarCuidador (idCuidador);
        }

        /*--------------------------------*/
        private static void BuscarCuidador(int idCuidador)
        {
            var cuidadorEncontrado =
                repositorioCuidador.GetCuidador(idCuidador);
            Console
                .WriteLine("Cuidador --> nombre: " +
                cuidadorEncontrado.Nombre);
        }

        /*--------------------------------*/
        private static void EditCuidador(int idCuidador)
        {
            Cuidador cuidador =
                new Cuidador {
                    Id = idCuidador,
                    Nombre = "Jorge Vargas",
                    Telefono = "358745469",
                    Edad = 35,
                    Direccion = "Calle 126 # 55-65",
                    Correo = "12356@cuidador.com",
                    Contraseña = "12356",
                    FechaRegistro = new DateTime(2021, 09, 23),
                    DireccionTrabajo = "Calle 124 # 76-18"
                };

            repositorioCuidador.editCuidador(cuidador);
        }
    }
}

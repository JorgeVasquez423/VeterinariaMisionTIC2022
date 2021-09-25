using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioCuidador : IRepositorioCuidador
    {
        private readonly AppContext appContext;

        public RepositorioCuidador(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        public Cuidador addCuidador(Cuidador cuidador)
        {
            var cuidadorAdicionado = this.appContext.Cuidadores.Add(cuidador);
            this.appContext.SaveChanges();
            Console.WriteLine("Cuidador agregado");

            return cuidadorAdicionado.Entity;
        }

        public Cuidador editCuidador(Cuidador cuidadorNuevo)
        {
            var cuidadorEncontrado =
                this
                    .appContext
                    .Cuidadores
                    .FirstOrDefault(v => v.Id == cuidadorNuevo.Id);

            if (cuidadorEncontrado != null)
            {
                cuidadorEncontrado.Nombre = cuidadorNuevo.Nombre;
                cuidadorEncontrado.Telefono = cuidadorNuevo.Telefono;
                cuidadorEncontrado.Edad = cuidadorNuevo.Edad;
                cuidadorEncontrado.Direccion = cuidadorNuevo.Direccion;
                cuidadorEncontrado.Correo = cuidadorNuevo.Correo;
                cuidadorEncontrado.Contraseña = cuidadorNuevo.Contraseña;
                cuidadorEncontrado.FechaRegistro =
                    cuidadorNuevo.FechaRegistro;
                cuidadorEncontrado.DireccionTrabajo =
                    cuidadorNuevo.DireccionTrabajo;
                this.appContext.SaveChanges();
            }

            return null;
        }

        public void eliminarCuidador(int idCuidador)
        {
            var cuidadorEncontrado =
                this
                    .appContext
                    .Cuidadores
                    .FirstOrDefault(v => v.Id == idCuidador);

            if (cuidadorEncontrado == null)
            {
                //return null;
                //var x=5;
                Console
                    .WriteLine("no existe el id del cuidador que desea eliminar");
                return;
            }
            else
            {
                this.appContext.Cuidadores.Remove(cuidadorEncontrado);
                this.appContext.SaveChanges();
                Console.WriteLine("Cuidador Eliminado");
            }
        }

        public Cuidador GetCuidador(int idCuidador)
        {
            var cuidadorEncontrado =
                this
                    .appContext
                    .Cuidadores
                    .FirstOrDefault(v => v.Id == idCuidador);

            if (cuidadorEncontrado != null)
            {
                return cuidadorEncontrado;
            }
            else
            {
                Console.WriteLine("Cuidador no encontrado");
                return null;
            }
        }

        public IEnumerable<Cuidador> GetCuidadores()
        {
            return null;
        }
    }
}

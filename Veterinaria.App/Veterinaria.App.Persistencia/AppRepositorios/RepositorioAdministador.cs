using System;
using Veterinaria.App.Dominio;
using System.Collections.Generic;//linkedList arrayList
using System.Linq;

namespace Veterinaria.App.Persistencia{

    

    public class RepositorioAdministador : IRepositorioAdministador{
        private readonly AppContext appContext;

        //constructor
        public RepositorioAdministador (AppContext appContextParam){
            this.appContext = appContextParam;
        }

        public Administrador addAdministrador(Administrador administrador){

            var adminAdicionado = this.appContext.Administradores.Add(administrador);
            this.appContext.SaveChanges();

            return adminAdicionado.Entity;

        }

        public Administrador editAdministrador(Administrador administradorNuevo){
            var adminEncontrado = this.appContext.Administradores.FirstOrDefault(a => a.Id == administradorNuevo.Id);
            if (adminEncontrado != null){

                adminEncontrado.Nombre  = administradorNuevo.Nombre;
                adminEncontrado.Telefono  = administradorNuevo.Telefono;
                adminEncontrado.Edad  = administradorNuevo.Edad;
                adminEncontrado.Correo  = administradorNuevo.Correo;
                adminEncontrado.Contraseña  = administradorNuevo.Contraseña;
                adminEncontrado.FechaRegistro  = administradorNuevo.FechaRegistro;
                adminEncontrado.Cargo  = administradorNuevo.Cargo;
                this.appContext.SaveChanges();

            }
            
            return null;
        }
        public void eliminarAdministrador(int idAdmin){

            var adminEncontrado = this.appContext.Administradores.FirstOrDefault(a => a.Id == idAdmin);

            if(adminEncontrado == null){
                Console.WriteLine("no existe el id del administrador que desea eliminar");
                return ;
            }else
            {
                this.appContext.Administradores.Remove(adminEncontrado);
                this.appContext.SaveChanges();
                Console.WriteLine("administrador Eliminado");
            }

        }
        public Administrador GetAdministrador(int idAdmin){
            var adminEncontrado = this.appContext.Administradores.FirstOrDefault(a => a.Id == idAdmin);

            if(adminEncontrado != null){
                return adminEncontrado;
            }
            return null;
            
        }
        public IEnumerable<Administrador> GetAdministrador(){
            return null;

        }

    }


}

        
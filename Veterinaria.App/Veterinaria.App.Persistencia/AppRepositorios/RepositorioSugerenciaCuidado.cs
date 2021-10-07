using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioSugerenciaCuidado : IRepositorioSugerenciaCuidado
    {
        private readonly AppContext appContext;

        public RepositorioSugerenciaCuidado(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        public SugerenciaCuidado addSugerenciaCuidado(SugerenciaCuidado suegerenciaCuidado)
        {
            var sugCuidadoAdicionado = this.appContext.SugerenciaCuidados.Add(suegerenciaCuidado);
            this.appContext.SaveChanges();
            Console.WriteLine("Cuidador agregado");

            return sugCuidadoAdicionado.Entity;
        }

        public SugerenciaCuidado editSugerenciaCuidado(SugerenciaCuidado SugCuidadoNuevo)
        {
            var SugCuidadoEncontrado =
                this
                    .appContext
                    .SugerenciaCuidados
                    .FirstOrDefault(v => v.Id == SugCuidadoNuevo.Id);

            if (SugCuidadoEncontrado != null)
            {
                SugCuidadoEncontrado.Nombre = SugCuidadoNuevo.Nombre;
                SugCuidadoEncontrado.Descripcion = SugCuidadoNuevo.Descripcion;
                
                this.appContext.SaveChanges();
            }

            return null;
        }

        public void eliminarSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var SugCuidadoEncontrado =
                this
                    .appContext
                    .SugerenciaCuidados
                    .FirstOrDefault(v => v.Id == idSugerenciaCuidado);

            if (SugCuidadoEncontrado == null)
            {
                //return null;
                //var x=5;
                Console
                    .WriteLine("no existe el id de la sugerencia de cuidado que desea eliminar");
                return;
            }
            else
            {
                this.appContext.SugerenciaCuidados.Remove(SugCuidadoEncontrado);
                this.appContext.SaveChanges();
                Console.WriteLine("Sugerencia de Cuidado Eliminada");
            }
        }

        public SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var SugCuidadoEncontrado =
                this
                    .appContext
                    .SugerenciaCuidados
                    .FirstOrDefault(v => v.Id == idSugerenciaCuidado);

            if (SugCuidadoEncontrado != null)
            {
                return SugCuidadoEncontrado;
            }
            else
            {
                Console.WriteLine("Sugerencia de cuidado no encontrada");
                return null;
            }
        }

        public IEnumerable<SugerenciaCuidado> GetSugerenciaCuidado()
        {
            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioAgenda : IRepositorioAgenda
    {
        private readonly AppContext appContext;

        public RepositorioAgenda(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        /*  */
        public Agenda addAgenda(Agenda agenda)
        {
            var AgendaAdicionado = this.appContext.Agendas.Add(agenda);
            this.appContext.SaveChanges();
            Console.WriteLine("Agenda agregada");

            return AgendaAdicionado.Entity;


        }
        public Agenda editAgenda(Agenda agendaNuevo)
        {
            var AgendaEncontrado = this.appContext.Agendas.FirstOrDefault(v => v.Id == agendaNuevo.Id);

            if (AgendaEncontrado != null)
            {
                AgendaEncontrado.FechaRegistro = agendaNuevo.FechaRegistro;
                AgendaEncontrado.Descriction = agendaNuevo.Descriction;
                this.appContext.SaveChanges();
            }

            return null;

        }
        public void eliminarAgenda(int idAgenda)
        {

            var AgendaEncontrado =
                this
                    .appContext
                    .Agendas
                    .FirstOrDefault(v => v.Id == idAgenda);

            if (AgendaEncontrado == null)
            {
                //return null;
                //var x=5;
                Console
                    .WriteLine("no existe el id de la Agenda que desea eliminar");
                return;
            }
            else
            {
                this.appContext.Agendas.Remove(AgendaEncontrado);
                this.appContext.SaveChanges();
                Console.WriteLine("Agenda Eliminada");
            }
            return;


        }
        public Agenda GetAgenda(int idAgenda)
        {
            var AgendaEncontrado =
                this
                    .appContext
                    .Agendas
                    .FirstOrDefault(v => v.Id == idAgenda);

            if (AgendaEncontrado != null)
            {
                return AgendaEncontrado;
            }
            else
            {
                Console.WriteLine("Agenda no encontrado");
                return null;
            }


        }
        public IEnumerable<Agenda> GetAgenda()
        {
            return null;


        }


    }
}
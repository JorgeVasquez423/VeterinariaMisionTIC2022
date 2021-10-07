using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly AppContext appContext;

        public RepositorioCita(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext appContext;

        public RepositorioHistoriaClinica(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        
    }
}
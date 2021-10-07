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

        
    }
}
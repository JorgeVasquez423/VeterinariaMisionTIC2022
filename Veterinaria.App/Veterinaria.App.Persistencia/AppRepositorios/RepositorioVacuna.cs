using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioVacuna : IRepositorioVacuna
    {
        private readonly AppContext appContext;

        public RepositorioVacuna(AppContext appContextParam)
        {
            this.appContext = appContextParam;
        }

        
    }
}
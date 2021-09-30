using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Veterinaria.App.Presentacion.Pages
{
    public class CuidadorModel : PageModel
    {
        private readonly ILogger<CuidadorModel> _logger;

        public CuidadorModel(ILogger<CuidadorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

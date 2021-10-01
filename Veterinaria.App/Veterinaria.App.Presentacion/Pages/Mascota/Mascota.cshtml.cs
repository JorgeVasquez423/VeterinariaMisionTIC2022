using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Veterinaria.App.Presentacion.Pages
{
    public class MascotaModel : PageModel
    {
        private readonly ILogger<MascotaModel> _logger;

        public MascotaModel(ILogger<MascotaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

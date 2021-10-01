using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Veterinaria.App.Presentacion.Pages
{
    public class VeterinarioModel : PageModel
    {
        private readonly ILogger<VeterinarioModel> _logger;

        public VeterinarioModel(ILogger<VeterinarioModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Presentacion.Pages
{
    public class IndexModel : PageModel
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostLogin(string Correo, string Contrasena)
        {
            Console.WriteLine("Correo: " + Correo);
            Console.WriteLine("Contrasena: " + Contrasena);

            var ganadero = _repositorioGanadero.GetLogin(Correo, Contrasena);

            if (ganadero != null)
            {
                Console.WriteLine("Inicio de sesión exitoso");
                Console.WriteLine("Nombre: " + ganadero.Nombres);

                Response.Cookies.Append("nombre", ganadero.Nombres);  
                Response.Cookies.Append("apellido", ganadero.Apellidos);   
                Response.Cookies.Append("correo", ganadero.Correo);  

                return Redirect("/Ganadero/List");

            } else
            {
                Console.WriteLine("Inicio de sesión incorrecta");
                return Page();
            }

        }
    }
}

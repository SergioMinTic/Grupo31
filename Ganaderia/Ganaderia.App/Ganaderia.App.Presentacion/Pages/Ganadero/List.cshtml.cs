using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        public List<Ganadero> Ganaderos { get; set; }
        public void OnGet()
        {
            var ganadero = new Ganadero
            {
                Nombres = "Sergio",
                Apellidos = "Moreno",
                NumeroTelefono = "3148596562",
                Correo = "sergiomintic@mintic.edu.co",
                Contrasena = "123456",
                Latitud = 4554,
                Longitud = 5454
            };

            var ganadero2 = new Ganadero
            {
                Nombres = "Cristiano",
                Apellidos = "Ronaldo",
                NumeroTelefono = "3148596562",
                Correo = "Ronaldo@mintic.edu.co",
                Contrasena = "123456",
                Latitud = 4554,
                Longitud = 5454
            };

            var ganadero3 = new Ganadero
            {
                Nombres = "Sergio",
                Apellidos = "Aguero",
                NumeroTelefono = "3148596562",
                Correo = "Sergio@mintic.edu.co",
                Contrasena = "123456",
                Latitud = 4554,
                Longitud = 5454
            };

            var ganadero4 = new Ganadero
            {
                Nombres = "Juan",
                Apellidos = "Cuadrado",
                NumeroTelefono = "3148596562",
                Correo = "Juan@mintic.edu.co",
                Contrasena = "123456",
                Latitud = 4554,
                Longitud = 5454
            };

            var ganadero5 = new Ganadero
            {
                Nombres = "David",
                Apellidos = "Ospina",
                NumeroTelefono = "3148596562",
                Correo = "sergiomintic@mintic.edu.co",
                Contrasena = "123456",
                Latitud = 4554,
                Longitud = 5454
            };


            Ganaderos = new List<Ganadero>();

            Ganaderos.Add(ganadero);
            Ganaderos.Add(ganadero2);
            Ganaderos.Add(ganadero3);
            Ganaderos.Add(ganadero4);
            Ganaderos.Add(ganadero5);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public List<Ganadero> Ganaderos { get; set; }

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Ganadero> Get()
        {
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // })
            // .ToArray();

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

            return Ganaderos;


        }
    }
}

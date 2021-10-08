using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;
using System.Collections.Generic;

namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repositorioGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioGanado _repositorioGanado = new RepositorioGanado(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // AddGanadero();
            // AddVeterinario();
            // AddGanado();
            // AsignarVeterinarioAGanado();
            // AddGanadoVacunasVeterinario();
            // DeleteGanadero(1);
            GetAllVeterinarios();
        }

        private static void AddGanadero()
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

            _repositorioGanadero.AddGanadero(ganadero);


        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Juan",
                Apellidos = "Cuadrado",
                NumeroTelefono = "312432322",
                Correo = "juan@mintic.edu.co",
                Contrasena = "987654",
                TargetaProfesional = 123455,
                Especialidad = 1
            };

            _repositorioVeterinario.AddVeterinario(veterinario);
        }

        private static void AddGanado()
        {
            var ganado = new Ganado
            {
                Raza = "Porcino",
                Alias = "Cerca del rio",
                Cantidad = 10,
                Veterinario = null,
                Vacunas = null
            };

            _repositorioGanado.AddGanado(ganado);
        }

        private static void AddGanadoVacunasVeterinario()
        {

            var veterinario = new Veterinario
            {
                Nombres = "David",
                Apellidos = "Ospina",
                NumeroTelefono = "312432322",
                Correo = "david@mintic.edu.co",
                Contrasena = "987654",
                TargetaProfesional = 123455,
                Especialidad = 1
            };

            List<Vacuna> vacunas = new List<Vacuna>();

            Vacuna vac1 = new Vacuna
            {
                Nombre = "Pisis",
                Fabricante = "MK",
                Descripcion = "Sirve para los dolores",
                FechaVencimiento = DateTime.Now
            };

            Vacuna vac2 = new Vacuna
            {
                Nombre = "Espiro",
                Fabricante = "MK",
                Descripcion = "Sirve para las infecciones",
                FechaVencimiento = DateTime.Now
            };


            Vacuna vac3 = new Vacuna
            {
                Nombre = "Yaiira",
                Fabricante = "MK",
                Descripcion = "Sirve para los hongos",
                FechaVencimiento = DateTime.Now
            };

            vacunas.Add(vac1);
            vacunas.Add(vac2);
            vacunas.Add(vac3);

            var ganado = new Ganado
            {
                Raza = "Pecuario",
                Alias = "En la casa",
                Cantidad = 20,
                Veterinario = veterinario,
                Vacunas = vacunas
            };

            _repositorioGanado.AddGanado(ganado);
        }

        private static void AsignarVeterinarioAGanado()
        {
            _repositorioGanado.AsignarVeterinarioAGanado(1, 2);
        }

        private static void DeleteGanadero(int idGanadero)
        {
            _repositorioGanadero.DeleteGanadero(idGanadero);
        }

        private static void GetAllVeterinarios()
        {
            var veterinarios = _repositorioVeterinario.GetAllVeterinarios();

            foreach (var veterinario in veterinarios)
            {
                Console.WriteLine(veterinario.Nombres + " - " + veterinario.Apellidos);
            }

        }

    }
}

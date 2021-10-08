using System;

namespace Ganaderia.App.Dominio
{
    public class Vacuna
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Fabricante { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
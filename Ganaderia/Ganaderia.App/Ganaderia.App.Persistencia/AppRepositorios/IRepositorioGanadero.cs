using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanadero
    {
       void AddGanadero(Ganadero ganadero);

       void DeleteGanadero(int idGanadero);

       IEnumerable<Ganadero> GetAllGanaderos();

       Ganadero GetGanadero(int idGanadero);

       Ganadero GetLogin(string correo, string contrasena);
    }
}
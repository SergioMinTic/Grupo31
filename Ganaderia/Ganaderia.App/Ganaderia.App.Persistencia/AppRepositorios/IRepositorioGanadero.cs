using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanadero
    {
       void AddGanadero(Ganadero ganadero);

       void DeleteGanadero(int idGanadero);
    }
}
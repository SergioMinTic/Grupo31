using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanado
    {
        void AddGanado(Ganado ganado);

        Ganado AsignarVeterinarioAGanado(int idGanado, int idVeterinario);

    }
}
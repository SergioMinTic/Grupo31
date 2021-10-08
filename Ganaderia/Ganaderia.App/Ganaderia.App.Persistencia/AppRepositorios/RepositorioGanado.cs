using System;
using System.Collections.Generic;
using System.Linq;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanado : IRepositorioGanado
    {
        private readonly AppContext _appContext;

        public RepositorioGanado(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioGanado.AddGanado(Ganado ganado)
        {
            _appContext.Ganados.Add(ganado);
            _appContext.SaveChanges();
        }

        Ganado IRepositorioGanado.AsignarVeterinarioAGanado(int idGanado, int idVeterinario)
        {
            var ganadoEncontrado = _appContext.Ganados.FirstOrDefault(g => g.Id == idGanado);
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(g => g.Id == idVeterinario);

            if (ganadoEncontrado != null && veterinarioEncontrado != null) {
                ganadoEncontrado.Veterinario = veterinarioEncontrado;

                _appContext.SaveChanges();
            }
            return ganadoEncontrado;
        }

    } 
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public class ProEventosPersistence : IProEventosPersistence
    {
        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void DeleteRange<T>(T[] entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delte<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsync(bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string tema, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos)
        {
            throw new NotImplementedException();
        }
    }
}
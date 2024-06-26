using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        // Palestrantes
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string noem, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos );
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos);

    }
}
using CustomArtScharp.Server.Models;

namespace CustomArtScharp.Server.Data.Repositories.Interfaces
{
    public interface IArteRepository : IRepository<Arte>
    {
        Task<IEnumerable<Arte>> ObterPorUsuarioIdAsync(int usuarioId);
    }
}
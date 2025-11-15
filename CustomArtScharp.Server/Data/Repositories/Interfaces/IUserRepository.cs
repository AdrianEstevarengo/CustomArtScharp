using CustomArtScharp.Server.Models;

namespace CustomArtScharp.Server.Data.Repositories.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario?> ObterPorEmailAsync(string email);
    }
}
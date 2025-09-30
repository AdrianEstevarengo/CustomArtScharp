using CustomArtScharp.Server.Models;

namespace CustomArtScharp.Server.Data.Repositories.Interfaces
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<IEnumerable<Pedido>> ObterPorUsuarioIdAsync(int usuarioId);
    }
}
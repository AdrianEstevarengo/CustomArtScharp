using CustomArtScharp.Server.Models;

namespace CustomArtScharp.Server.Data.Repositories.Interfaces
{
    public interface IQuadroRepository : IRepository<Quadro>
    {
        Task<IEnumerable<Quadro>> ObterPorPedidoIdAsync(int pedidoId);
    }
}
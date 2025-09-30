using CustomArtScharp.Server.Data.Context;
using CustomArtScharp.Server.Data.Repositories.Interfaces;
using CustomArtScharp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomArtScharp.Server.Data.Repositories
{
    public class QuadroRepository : Repository<Quadro>, IQuadroRepository
    {
        public QuadroRepository(AppDbContext contexto) : base(contexto) { }

        public async Task<IEnumerable<Quadro>> ObterPorPedidoIdAsync(int pedidoId)
        {
            return await _dbSet.Where(f => f.PedidoId == pedidoId).ToListAsync();
        }
    }
}
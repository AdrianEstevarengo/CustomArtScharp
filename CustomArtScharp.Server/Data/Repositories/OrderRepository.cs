using CustomArtScharp.Server.Data.Context;
using CustomArtScharp.Server.Data.Repositories.Interfaces;
using CustomArtScharp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomArtScharp.Server.Data.Repositories
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(AppDbContext contexto) : base(contexto) { }

        public async Task<IEnumerable<Pedido>> ObterPorUsuarioIdAsync(int usuarioId)
        {
            return await _dbSet.Where(o => o.UsuarioId == usuarioId).ToListAsync();
        }
    }
}
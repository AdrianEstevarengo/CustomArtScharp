using CustomArtScharp.Server.Data.Context;
using CustomArtScharp.Server.Data.Repositories.Interfaces;
using CustomArtScharp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomArtScharp.Server.Data.Repositories
{
    public class ArteRepository : Repository<Arte>, IArteRepository
    {
        public ArteRepository(AppDbContext contexto) : base(contexto) { }

        public async Task<IEnumerable<Arte>> ObterPorUsuarioIdAsync(int usuarioId)
        {
            return await _dbSet.Where(a => a.UsuarioId == usuarioId).ToListAsync();
        }
    }
}
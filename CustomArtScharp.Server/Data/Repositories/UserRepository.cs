using CustomArtScharp.Server.Data.Context;
using CustomArtScharp.Server.Data.Repositories.Interfaces;
using CustomArtScharp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomArtScharp.Server.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext contexto) : base(contexto) { }

        public async Task<Usuario?> ObterPorEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
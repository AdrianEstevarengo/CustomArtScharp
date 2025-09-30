using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomArtScharp.Server.Data.Context;
using CustomArtScharp.Server.Data.Repositories.Interfaces;

namespace CustomArtScharp.Server.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _contexto;
        protected readonly DbSet<T> _dbSet;

        public Repository(AppDbContext contexto)
        {
            _contexto = contexto;
            _dbSet = contexto.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> ObterTodosAsync()
            => await _dbSet.ToListAsync();

        public virtual async Task<T?> ObterPorIdAsync(int id)
            => await _dbSet.FindAsync(id);

        public virtual async Task<T> AdicionarAsync(T entidade)
        {
            _dbSet.Add(entidade);
            await _contexto.SaveChangesAsync();
            return entidade;
        }

        public virtual async Task<T> AtualizarAsync(T entidade)
        {
            _dbSet.Update(entidade);
            await _contexto.SaveChangesAsync();
            return entidade;
        }

        public virtual async Task<bool> RemoverAsync(int id)
        {
            var entidade = await ObterPorIdAsync(id);
            if (entidade == null) return false;
            _dbSet.Remove(entidade);
            await _contexto.SaveChangesAsync();
            return true;
        }
    }
}
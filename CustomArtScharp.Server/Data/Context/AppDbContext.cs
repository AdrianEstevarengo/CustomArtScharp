using Microsoft.EntityFrameworkCore;
using CustomArtScharp.Server.Models;

namespace CustomArtScharp.Server.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Arte> Artes { get; set; }
        public DbSet<Quadro> Quadros { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("AgendaConsulta");

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Pedidos)
                .WithOne(o => o.Usuario)
                .HasForeignKey(o => o.UsuarioId);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Artes)
                .WithOne(a => a.Usuario)
                .HasForeignKey(a => a.UsuarioId);

            modelBuilder.Entity<Pedido>()
                .HasMany(o => o.Quadros)
                .WithOne(f => f.Pedido)
                .HasForeignKey(f => f.PedidoId);

            modelBuilder.Entity<Quadro>()
                .HasOne(f => f.Arte)
                .WithMany()
                .HasForeignKey(f => f.ArteId);
        }
    }
}
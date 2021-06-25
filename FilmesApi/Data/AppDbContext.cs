using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Endereco>()
                .HasOne(e => e.Cinema)
                .WithOne(c => c.Endereco)
                .HasForeignKey<Cinema>(c => c.EnderecoFK);

            modelBuilder
                .Entity<Sessao>()
                .HasOne(s => s.Cinema)
                .WithMany(c => c.Sessoes)
                .HasForeignKey(c => c.CinemaId);

            modelBuilder
                .Entity<Sessao>()
                .HasOne(s => s.Filme)
                .WithMany(c => c.Sessoes)
                .HasForeignKey(c => c.FilmeId);

            modelBuilder
                .Entity<Cinema>()
                .HasOne(c => c.Gerente)
                .WithMany(g => g.Cinema)
                .HasForeignKey(c => c.GerenteFK).IsRequired(false);


        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos{ get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using Peliculas.Data.Models;

namespace Peliculas.Data.Contexts
{
    public class PeliculasContext : DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext> options) : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Cine> Cines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("pelis");

            modelBuilder.Entity<Pelicula>().HasKey(e => e.Id);
            modelBuilder.Entity<Pelicula>().Property(p => p.Id).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno).HasColumnType("date");
        }
    }
}

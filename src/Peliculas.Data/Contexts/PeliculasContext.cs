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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("pelis");
        }
    }
}

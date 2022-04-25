using Microsoft.EntityFrameworkCore;
using Peliculas.Data.Extensions;
using Peliculas.Data.Models;
using System.Linq;

namespace Peliculas.Data.Contexts
{
    public class PeliculasContext : DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext> options) : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<PeliculaActor> PeliculaActores { get; set; }
        public DbSet<Genero> Generos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("pelis");

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Pelicula>().HasKey(e => e.Id);
            modelBuilder.Entity<Pelicula>().Property(p => p.Titulo).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(p => p.PosterUrl).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno).HasColumnType("date");

            modelBuilder.Entity<Actor>().HasKey(e => e.Id);
            modelBuilder.Entity<Actor>().Property(p => p.Nombre).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Actor>().Property(p => p.Biografia).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Actor>().Property(p => p.FechaNacimiento).HasColumnType("date");

            modelBuilder.Entity<PeliculaActor>().HasKey(p => new { p.PeliculaId, p.ActorId });
            modelBuilder.Entity<PeliculaActor>().HasOne(p => p.Pelicula);
            modelBuilder.Entity<PeliculaActor>().HasOne(p => p.Actor);
            modelBuilder.Entity<PeliculaActor>().Property(p => p.Personaje).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Cine>().HasKey(e => e.Id);
            modelBuilder.Entity<Cine>().Property(p => p.Nombre).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<SalaDeCine>().HasKey(e => e.Id);
            modelBuilder.Entity<SalaDeCine>().Property(p => p.TipoSalaCine).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<SalaDeCine>().Property(p => p.Precio).HasPrecision(9, 2);

            modelBuilder.Entity<PeliculaSalaDeCine>().HasKey(p => new { p.PeliculaId, p.SalaDeCineId });
            modelBuilder.Entity<PeliculaSalaDeCine>().HasOne(p => p.Pelicula);
            modelBuilder.Entity<PeliculaSalaDeCine>().HasOne(p => p.SalaDeCine);

            modelBuilder.Entity<Genero>().HasKey(e => e.Identificador);
            modelBuilder.Entity<Genero>().Property(p => p.Nombre).HasColumnType("nvarchar(50)").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<GeneroPelicula>().HasKey(p => new { p.PeliculaId, p.GeneroIdentificador });
            modelBuilder.Entity<GeneroPelicula>().HasOne(p => p.Pelicula);
            modelBuilder.Entity<GeneroPelicula>().HasOne(p => p.Genero);

            modelBuilder.Entity<CineOferta>().HasKey(e => e.Id);
            modelBuilder.Entity<CineOferta>().HasOne<Cine>(p => p.Cine).WithOne(p => p.CineOferta).HasForeignKey<Cine>(p => p.Id);
            modelBuilder.Entity<CineOferta>().Property(p => p.PorcentajeDescuento).HasPrecision(9, 2);
            modelBuilder.Entity<CineOferta>().Property(p => p.FechaInicio).HasColumnType("date");
            modelBuilder.Entity<CineOferta>().Property(p => p.FechaFin).HasColumnType("date");

            modelBuilder.ExecuteDataSeeding();

            base.OnModelCreating(modelBuilder);
        }
    }
}
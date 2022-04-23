using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Peliculas.Data.Geometry;
using Peliculas.Data.Models;
using System;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("pelis");

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

            modelBuilder.ExecuteDataSeeding();
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void ExecuteDataSeeding(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelicula>().HasData(
                new Pelicula { Id = 1, Titulo = "Lord of Rings", EnCartelera = false, FechaEstreno = new DateTime(2000, 1, 1), PosterUrl = "http://www.lordofrings-themovie.com"},
                new Pelicula { Id = 2, Titulo = "Sonic 2", EnCartelera = true, FechaEstreno = new DateTime(2022, 4, 22), PosterUrl = "http://www.sonic2-themovie.com" }
            );

            Point ubicacionCartago = GeometryFactoryHelper.GeometryFactory.CreatePoint(new Coordinate(9.86, -83.95));
            Point ubicacionTresRios = GeometryFactoryHelper.GeometryFactory.CreatePoint(new Coordinate(9.90, -83.98));

            modelBuilder.Entity<Cine>().HasData(
                new Cine { Id = 1, Nombre = "Cinepolis Cartago", Ubicacion = ubicacionCartago },
                new Cine { Id = 2, Nombre = "Cinepolis Tres Rios", Ubicacion = ubicacionTresRios }
            );
        }
    }
}
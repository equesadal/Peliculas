using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Peliculas.Data.Geometry;
using Peliculas.Data.Models;
using System;
using System.Collections.Generic;

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
            //modelBuilder.Entity<Pelicula>().HasMany(p => p.SalasDeCine);

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

            modelBuilder.ExecuteDataSeeding();
        }
    }

    public static class ModelBuilderExtensions
    {
        public static void ExecuteDataSeeding(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelicula>().HasData(
                new Pelicula { Id = 1, Titulo = "Lord of Rings", EnCartelera = false, FechaEstreno = new DateTime(2000, 1, 1), PosterUrl = "http://www.lordofrings-themovie.com"},
                new Pelicula { Id = 2, Titulo = "Sonic 2", EnCartelera = true, FechaEstreno = new DateTime(2022, 2, 1), PosterUrl = "http://www.sonic2-themovie.com" },
                new Pelicula { Id = 3, Titulo = "Red", EnCartelera = false, FechaEstreno = new DateTime(2022, 2, 1), PosterUrl = "http://www.dummyurl.com" },
                new Pelicula { Id = 4, Titulo = "Moonfall", EnCartelera = false, FechaEstreno = new DateTime(2022, 3, 1), PosterUrl = "http://www.dummyurl.com" },
                new Pelicula { Id = 5, Titulo = "The 355", EnCartelera = false, FechaEstreno = new DateTime(2022, 2, 10), PosterUrl = "http://www.dummyurl.com" },
                new Pelicula { Id = 6, Titulo = "Scream", EnCartelera = false, FechaEstreno = new DateTime(2022, 2, 15), PosterUrl = "http://www.dummyurl.com" },
                new Pelicula { Id = 7, Titulo = "Marry Me", EnCartelera = false, FechaEstreno = new DateTime(2022, 3, 1), PosterUrl = "http://www.dummyurl.com" },
                new Pelicula { Id = 8, Titulo = "Death on the Nile", EnCartelera = true, FechaEstreno = new DateTime(2022, 3, 1), PosterUrl = "http://www.dummyurl.com" },
                new Pelicula { Id = 9, Titulo = "Uncharted", EnCartelera = false, FechaEstreno = new DateTime(2022, 3, 10), PosterUrl = "http://www.dummyurl.com" },
                new Pelicula { Id = 10, Titulo = "The Batman", EnCartelera = true, FechaEstreno = new DateTime(2022, 3, 15), PosterUrl = "http://www.dummyurl.com" },
                new Pelicula { Id = 11, Titulo = "The Adam Project", EnCartelera = true, FechaEstreno = new DateTime(2022, 4, 1), PosterUrl = "http://www.dummyurl.com" }
            );

            Point ubicacionCartago = GeometryFactoryHelper.GeometryFactory.CreatePoint(new Coordinate(9.86, -83.95));
            Point ubicacionTresRios = GeometryFactoryHelper.GeometryFactory.CreatePoint(new Coordinate(9.90, -83.98));

            modelBuilder.Entity<Cine>().HasData(
                new Cine { Id = 1, Nombre = "Cinepolis Cartago", Ubicacion = ubicacionCartago },
                new Cine { Id = 2, Nombre = "Cinepolis Tres Rios", Ubicacion = ubicacionTresRios },
                new Cine { Id = 3, Nombre = "Multiplaza Cines", Ubicacion = ubicacionTresRios }
            );

            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Nombre = "Elijah Wood", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 2, Nombre = "Idris Elba", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 3, Nombre = "Rosalie Chiang", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 4, Nombre = "Halle Berry", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 5, Nombre = "Jessica Chastain", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 6, Nombre = "Neve Campbell", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 7, Nombre = "Jennifer Lopez", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 8, Nombre = "Gal Gadot", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 9, Nombre = "Tom Holland", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 10, Nombre = "Robert Pattinson", Biografia = "Bio here", FechaNacimiento = DateTime.Now },
                new Actor { Id = 11, Nombre = "Ryan Reynolds", Biografia = "Bio here", FechaNacimiento = DateTime.Now }
            );

            modelBuilder.Entity<PeliculaActor>().HasData(
                new PeliculaActor { PeliculaId = 1, ActorId = 1, Personaje = "Frodo", Orden = 1 },
                new PeliculaActor { PeliculaId = 2, ActorId = 2, Personaje = "Sonic", Orden = 1 },
                new PeliculaActor { PeliculaId = 3, ActorId = 3, Personaje = "Mei Lee", Orden = 1 },
                new PeliculaActor { PeliculaId = 4, ActorId = 4, Personaje = "Jocinda Fowler", Orden = 1 },
                new PeliculaActor { PeliculaId = 5, ActorId = 5, Personaje = "Mace", Orden = 1 },
                new PeliculaActor { PeliculaId = 6, ActorId = 6, Personaje = "Ghostface", Orden = 1 },
                new PeliculaActor { PeliculaId = 7, ActorId = 7, Personaje = "Kat Valdez", Orden = 1 },
                new PeliculaActor { PeliculaId = 8, ActorId = 8, Personaje = "Linnet Ridge", Orden = 1 },
                new PeliculaActor { PeliculaId = 9, ActorId = 9, Personaje = "Nathan Drake", Orden = 1 },
                new PeliculaActor { PeliculaId = 10, ActorId = 10, Personaje = "Batman", Orden = 1 },
                new PeliculaActor { PeliculaId = 11, ActorId = 11, Personaje = "Adam Reed", Orden = 1 }
            );

            modelBuilder.Entity<SalaDeCine>().HasData(
                new SalaDeCine { Id = 1, CineId = 1, Precio = 3500, TipoSalaCine = "3D"},
                new SalaDeCine { Id = 2, CineId = 2, Precio = 3500, TipoSalaCine = "3D" },
                new SalaDeCine { Id = 3, CineId = 3, Precio = 3500, TipoSalaCine = "3D" },
                new SalaDeCine { Id = 4, CineId = 1, Precio = 3500, TipoSalaCine = "3D" },
                new SalaDeCine { Id = 5, CineId = 2, Precio = 3500, TipoSalaCine = "3D" },
                new SalaDeCine { Id = 6, CineId = 3, Precio = 3500, TipoSalaCine = "3D" },
                new SalaDeCine { Id = 7, CineId = 1, Precio = 3500, TipoSalaCine = "3D" },
                new SalaDeCine { Id = 8, CineId = 2, Precio = 3500, TipoSalaCine = "3D" },
                new SalaDeCine { Id = 9, CineId = 3, Precio = 3500, TipoSalaCine = "3D" },
                new SalaDeCine { Id = 10, CineId = 1, Precio = 3500, TipoSalaCine = "3D" },
                new SalaDeCine { Id = 11, CineId = 2, Precio = 3500, TipoSalaCine = "3D" }
            );

            modelBuilder.Entity<PeliculaSalaDeCine>().HasData(
                new PeliculaSalaDeCine { PeliculaId = 1, SalaDeCineId = 1 },
                new PeliculaSalaDeCine { PeliculaId = 1, SalaDeCineId = 7 },
                new PeliculaSalaDeCine { PeliculaId = 2, SalaDeCineId = 2 },
                new PeliculaSalaDeCine { PeliculaId = 2, SalaDeCineId = 8 },
                new PeliculaSalaDeCine { PeliculaId = 3, SalaDeCineId = 3 },
                new PeliculaSalaDeCine { PeliculaId = 3, SalaDeCineId = 9 },
                new PeliculaSalaDeCine { PeliculaId = 4, SalaDeCineId = 4 },
                new PeliculaSalaDeCine { PeliculaId = 4, SalaDeCineId = 10 },
                new PeliculaSalaDeCine { PeliculaId = 5, SalaDeCineId = 5 },
                new PeliculaSalaDeCine { PeliculaId = 5, SalaDeCineId = 11 },
                new PeliculaSalaDeCine { PeliculaId = 6, SalaDeCineId = 5 },
                new PeliculaSalaDeCine { PeliculaId = 7, SalaDeCineId = 6 },
                new PeliculaSalaDeCine { PeliculaId = 8, SalaDeCineId = 7 },
                new PeliculaSalaDeCine { PeliculaId = 9, SalaDeCineId = 8 },
                new PeliculaSalaDeCine { PeliculaId = 10, SalaDeCineId = 9 },
                new PeliculaSalaDeCine { PeliculaId = 11, SalaDeCineId = 10 }
            );
        }
    }
}
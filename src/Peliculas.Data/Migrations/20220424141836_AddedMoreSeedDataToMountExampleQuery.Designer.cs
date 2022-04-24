﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Peliculas.Data.Contexts;

namespace Peliculas.Data.Migrations
{
    [DbContext(typeof(PeliculasContext))]
    [Migration("20220424141836_AddedMoreSeedDataToMountExampleQuery")]
    partial class AddedMoreSeedDataToMountExampleQuery
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("pelis")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Peliculas.Data.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biografia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Actores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 60, DateTimeKind.Local).AddTicks(7160),
                            Nombre = "Elijah Wood"
                        },
                        new
                        {
                            Id = 2,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2700),
                            Nombre = "Idris Elba"
                        },
                        new
                        {
                            Id = 3,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2760),
                            Nombre = "Rosalie Chiang"
                        },
                        new
                        {
                            Id = 4,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2769),
                            Nombre = "Halle Berry"
                        },
                        new
                        {
                            Id = 5,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2771),
                            Nombre = "Jessica Chastain"
                        },
                        new
                        {
                            Id = 6,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2773),
                            Nombre = "Neve Campbell"
                        },
                        new
                        {
                            Id = 7,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2776),
                            Nombre = "Jennifer Lopez"
                        },
                        new
                        {
                            Id = 8,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2778),
                            Nombre = "Gal Gadot"
                        },
                        new
                        {
                            Id = 9,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2780),
                            Nombre = "Tom Holland"
                        },
                        new
                        {
                            Id = 10,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2782),
                            Nombre = "Robert Pattinson"
                        },
                        new
                        {
                            Id = 11,
                            Biografia = "Bio here",
                            FechaNacimiento = new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2785),
                            Nombre = "Ryan Reynolds"
                        });
                });

            modelBuilder.Entity("Peliculas.Data.Models.Cine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Point>("Ubicacion")
                        .HasColumnType("geography");

                    b.HasKey("Id");

                    b.ToTable("Cines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Cinepolis Cartago",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (9.86 -83.95)")
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Cinepolis Tres Rios",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (9.9 -83.98)")
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Multiplaza Cines",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (9.9 -83.98)")
                        });
                });

            modelBuilder.Entity("Peliculas.Data.Models.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EnCartelera")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("date");

                    b.Property<string>("PosterUrl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.lordofrings-themovie.com",
                            Titulo = "Lord of Rings"
                        },
                        new
                        {
                            Id = 2,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.sonic2-themovie.com",
                            Titulo = "Sonic 2"
                        },
                        new
                        {
                            Id = 3,
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Red"
                        },
                        new
                        {
                            Id = 4,
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Moonfall"
                        },
                        new
                        {
                            Id = 5,
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "The 355"
                        },
                        new
                        {
                            Id = 6,
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Scream"
                        },
                        new
                        {
                            Id = 7,
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Marry Me"
                        },
                        new
                        {
                            Id = 8,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Death on the Nile"
                        },
                        new
                        {
                            Id = 9,
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Uncharted"
                        },
                        new
                        {
                            Id = 10,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "The Batman"
                        },
                        new
                        {
                            Id = 11,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "The Adam Project"
                        },
                        new
                        {
                            Id = 12,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Other Movie 1"
                        },
                        new
                        {
                            Id = 13,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Other Movie 2"
                        },
                        new
                        {
                            Id = 14,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Other Movie 3"
                        },
                        new
                        {
                            Id = 15,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Other Movie 4"
                        },
                        new
                        {
                            Id = 16,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Other Movie 5"
                        },
                        new
                        {
                            Id = 17,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Other Movie 6"
                        },
                        new
                        {
                            Id = 18,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Other Movie 7"
                        },
                        new
                        {
                            Id = 19,
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterUrl = "http://www.dummyurl.com",
                            Titulo = "Other Movie 8"
                        });
                });

            modelBuilder.Entity("Peliculas.Data.Models.PeliculaActor", b =>
                {
                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PeliculaId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("PeliculaActores");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Frodo"
                        },
                        new
                        {
                            PeliculaId = 2,
                            ActorId = 2,
                            Orden = 1,
                            Personaje = "Sonic"
                        },
                        new
                        {
                            PeliculaId = 3,
                            ActorId = 3,
                            Orden = 1,
                            Personaje = "Mei Lee"
                        },
                        new
                        {
                            PeliculaId = 4,
                            ActorId = 4,
                            Orden = 1,
                            Personaje = "Jocinda Fowler"
                        },
                        new
                        {
                            PeliculaId = 5,
                            ActorId = 5,
                            Orden = 1,
                            Personaje = "Mace"
                        },
                        new
                        {
                            PeliculaId = 6,
                            ActorId = 6,
                            Orden = 1,
                            Personaje = "Ghostface"
                        },
                        new
                        {
                            PeliculaId = 7,
                            ActorId = 7,
                            Orden = 1,
                            Personaje = "Kat Valdez"
                        },
                        new
                        {
                            PeliculaId = 8,
                            ActorId = 8,
                            Orden = 1,
                            Personaje = "Linnet Ridge"
                        },
                        new
                        {
                            PeliculaId = 9,
                            ActorId = 9,
                            Orden = 1,
                            Personaje = "Nathan Drake"
                        },
                        new
                        {
                            PeliculaId = 10,
                            ActorId = 10,
                            Orden = 1,
                            Personaje = "Batman"
                        },
                        new
                        {
                            PeliculaId = 11,
                            ActorId = 11,
                            Orden = 1,
                            Personaje = "Adam Reed"
                        },
                        new
                        {
                            PeliculaId = 12,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Elijah!"
                        },
                        new
                        {
                            PeliculaId = 13,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Elijah!"
                        },
                        new
                        {
                            PeliculaId = 14,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Elijah!"
                        },
                        new
                        {
                            PeliculaId = 15,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Elijah!"
                        },
                        new
                        {
                            PeliculaId = 16,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Elijah!"
                        },
                        new
                        {
                            PeliculaId = 17,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Elijah!"
                        },
                        new
                        {
                            PeliculaId = 18,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Elijah!"
                        },
                        new
                        {
                            PeliculaId = 19,
                            ActorId = 1,
                            Orden = 1,
                            Personaje = "Elijah!"
                        });
                });

            modelBuilder.Entity("Peliculas.Data.Models.PeliculaSalaDeCine", b =>
                {
                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("SalaDeCineId")
                        .HasColumnType("int");

                    b.HasKey("PeliculaId", "SalaDeCineId");

                    b.HasIndex("SalaDeCineId");

                    b.ToTable("PeliculaSalaDeCine");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            SalaDeCineId = 1
                        },
                        new
                        {
                            PeliculaId = 1,
                            SalaDeCineId = 7
                        },
                        new
                        {
                            PeliculaId = 2,
                            SalaDeCineId = 2
                        },
                        new
                        {
                            PeliculaId = 2,
                            SalaDeCineId = 8
                        },
                        new
                        {
                            PeliculaId = 3,
                            SalaDeCineId = 3
                        },
                        new
                        {
                            PeliculaId = 3,
                            SalaDeCineId = 9
                        },
                        new
                        {
                            PeliculaId = 4,
                            SalaDeCineId = 4
                        },
                        new
                        {
                            PeliculaId = 4,
                            SalaDeCineId = 10
                        },
                        new
                        {
                            PeliculaId = 5,
                            SalaDeCineId = 5
                        },
                        new
                        {
                            PeliculaId = 5,
                            SalaDeCineId = 11
                        },
                        new
                        {
                            PeliculaId = 6,
                            SalaDeCineId = 5
                        },
                        new
                        {
                            PeliculaId = 7,
                            SalaDeCineId = 6
                        },
                        new
                        {
                            PeliculaId = 8,
                            SalaDeCineId = 7
                        },
                        new
                        {
                            PeliculaId = 9,
                            SalaDeCineId = 8
                        },
                        new
                        {
                            PeliculaId = 10,
                            SalaDeCineId = 9
                        },
                        new
                        {
                            PeliculaId = 11,
                            SalaDeCineId = 10
                        });
                });

            modelBuilder.Entity("Peliculas.Data.Models.SalaDeCine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.Property<string>("TipoSalaCine")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CineId");

                    b.ToTable("SalaDeCine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CineId = 1,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 2,
                            CineId = 2,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 3,
                            CineId = 3,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 4,
                            CineId = 1,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 5,
                            CineId = 2,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 6,
                            CineId = 3,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 7,
                            CineId = 1,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 8,
                            CineId = 2,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 9,
                            CineId = 3,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 10,
                            CineId = 1,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        },
                        new
                        {
                            Id = 11,
                            CineId = 2,
                            Precio = 3500m,
                            TipoSalaCine = "3D"
                        });
                });

            modelBuilder.Entity("Peliculas.Data.Models.PeliculaActor", b =>
                {
                    b.HasOne("Peliculas.Data.Models.Actor", "Actor")
                        .WithMany("PeliculaActores")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.Data.Models.Pelicula", "Pelicula")
                        .WithMany("PeliculaActores")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.Data.Models.PeliculaSalaDeCine", b =>
                {
                    b.HasOne("Peliculas.Data.Models.Pelicula", "Pelicula")
                        .WithMany("PeliculasSalasDeCine")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.Data.Models.SalaDeCine", "SalaDeCine")
                        .WithMany("PeliculasSalaDeCine")
                        .HasForeignKey("SalaDeCineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");

                    b.Navigation("SalaDeCine");
                });

            modelBuilder.Entity("Peliculas.Data.Models.SalaDeCine", b =>
                {
                    b.HasOne("Peliculas.Data.Models.Cine", "Cine")
                        .WithMany()
                        .HasForeignKey("CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cine");
                });

            modelBuilder.Entity("Peliculas.Data.Models.Actor", b =>
                {
                    b.Navigation("PeliculaActores");
                });

            modelBuilder.Entity("Peliculas.Data.Models.Pelicula", b =>
                {
                    b.Navigation("PeliculaActores");

                    b.Navigation("PeliculasSalasDeCine");
                });

            modelBuilder.Entity("Peliculas.Data.Models.SalaDeCine", b =>
                {
                    b.Navigation("PeliculasSalaDeCine");
                });
#pragma warning restore 612, 618
        }
    }
}
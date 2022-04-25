using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Peliculas.Data.Migrations
{
    public partial class DataSeedLoading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Actores",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Nombre" },
                values: new object[,]
                {
                    { 1, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 723, DateTimeKind.Local).AddTicks(3131), "Elijah Wood" },
                    { 2, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7403), "Idris Elba" },
                    { 3, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7453), "Rosalie Chiang" },
                    { 4, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7455), "Halle Berry" },
                    { 5, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7458), "Jessica Chastain" },
                    { 6, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7459), "Neve Campbell" },
                    { 7, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7461), "Jennifer Lopez" },
                    { 8, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7463), "Gal Gadot" },
                    { 9, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7464), "Tom Holland" },
                    { 10, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7466), "Robert Pattinson" },
                    { 11, "Bio here", new DateTime(2022, 4, 25, 9, 19, 28, 724, DateTimeKind.Local).AddTicks(7469), "Ryan Reynolds" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "CineOferta",
                columns: new[] { "Id", "CineId", "FechaFin", "FechaInicio", "PorcentajeDescuento" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m },
                    { 2, 2, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m },
                    { 3, 3, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Generos",
                columns: new[] { "Identificador", "Nombre" },
                values: new object[,]
                {
                    { 5, "Horror" },
                    { 4, "Fantasy" },
                    { 6, "Mistery" },
                    { 2, "Comedy" },
                    { 1, "Action" },
                    { 3, "Drama" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Peliculas",
                columns: new[] { "Id", "EnCartelera", "FechaEstreno", "PosterUrl", "Titulo" },
                values: new object[,]
                {
                    { 17, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 6" },
                    { 16, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 5" },
                    { 15, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 4" },
                    { 14, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 3" },
                    { 13, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 2" },
                    { 12, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 1" },
                    { 11, true, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "The Adam Project" },
                    { 10, true, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "The Batman" },
                    { 8, true, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Death on the Nile" },
                    { 7, false, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Marry Me" },
                    { 6, false, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Scream" },
                    { 5, false, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "The 355" },
                    { 4, false, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Moonfall" },
                    { 3, false, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Red" },
                    { 2, true, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.sonic2-themovie.com", "Sonic 2" },
                    { 1, false, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.lordofrings-themovie.com", "Lord of Rings" },
                    { 18, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 7" },
                    { 9, false, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Uncharted" },
                    { 19, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 8" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Cines",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[,]
                {
                    { 1, "Cinepolis Cartago", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (9.86 -83.95)") },
                    { 2, "Cinepolis Tres Rios", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (9.9 -83.98)") },
                    { 3, "Multiplaza Cines", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (9.9 -83.98)") }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "GeneroPelicula",
                columns: new[] { "GeneroIdentificador", "PeliculaId" },
                values: new object[,]
                {
                    { 4, 11 },
                    { 3, 10 },
                    { 2, 9 },
                    { 6, 8 },
                    { 5, 7 },
                    { 3, 5 },
                    { 2, 5 },
                    { 1, 4 },
                    { 6, 4 },
                    { 4, 6 },
                    { 5, 3 },
                    { 4, 3 },
                    { 3, 2 },
                    { 2, 2 },
                    { 4, 1 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "PeliculaActores",
                columns: new[] { "ActorId", "PeliculaId", "Orden", "Personaje" },
                values: new object[,]
                {
                    { 1, 17, 1, "Elijah!" },
                    { 1, 16, 1, "Elijah!" },
                    { 1, 15, 1, "Elijah!" },
                    { 1, 14, 1, "Elijah!" },
                    { 1, 13, 1, "Elijah!" },
                    { 1, 12, 1, "Elijah!" },
                    { 11, 11, 1, "Adam Reed" },
                    { 10, 10, 1, "Batman" },
                    { 9, 9, 1, "Nathan Drake" },
                    { 1, 1, 1, "Frodo" },
                    { 8, 8, 1, "Linnet Ridge" },
                    { 7, 7, 1, "Kat Valdez" },
                    { 6, 6, 1, "Ghostface" },
                    { 1, 18, 1, "Elijah!" },
                    { 5, 5, 1, "Mace" },
                    { 2, 2, 1, "Sonic" },
                    { 4, 4, 1, "Jocinda Fowler" },
                    { 3, 3, 1, "Mei Lee" },
                    { 1, 19, 1, "Elijah!" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "SalaDeCine",
                columns: new[] { "Id", "CineId", "Precio", "TipoSalaCine" },
                values: new object[,]
                {
                    { 1, 1, 3500m, "3D" },
                    { 4, 1, 3500m, "3D" },
                    { 7, 1, 3500m, "3D" },
                    { 10, 1, 3500m, "3D" },
                    { 2, 2, 3500m, "3D" },
                    { 5, 2, 3500m, "3D" },
                    { 8, 2, 3500m, "3D" },
                    { 11, 2, 3500m, "3D" },
                    { 3, 3, 3500m, "3D" },
                    { 6, 3, 3500m, "3D" },
                    { 9, 3, 3500m, "3D" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                columns: new[] { "PeliculaId", "SalaDeCineId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 17, 9 },
                    { 16, 9 },
                    { 15, 9 },
                    { 14, 9 },
                    { 13, 9 },
                    { 12, 9 },
                    { 10, 9 },
                    { 3, 9 },
                    { 7, 6 },
                    { 3, 3 },
                    { 5, 11 },
                    { 9, 8 },
                    { 2, 8 },
                    { 6, 5 },
                    { 5, 5 },
                    { 2, 2 },
                    { 11, 10 },
                    { 4, 10 },
                    { 8, 7 },
                    { 1, 7 },
                    { 4, 4 },
                    { 18, 9 },
                    { 19, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "GeneroPelicula",
                keyColumns: new[] { "GeneroIdentificador", "PeliculaId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculaId", "SalaDeCineId" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Generos",
                keyColumn: "Identificador",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Generos",
                keyColumn: "Identificador",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Generos",
                keyColumn: "Identificador",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Generos",
                keyColumn: "Identificador",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Generos",
                keyColumn: "Identificador",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Generos",
                keyColumn: "Identificador",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "SalaDeCine",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Cines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Cines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Cines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "CineOferta",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "CineOferta",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "CineOferta",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

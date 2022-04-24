using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Peliculas.Data.Migrations
{
    public partial class AddedSeedDataForMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaSalaDeCine_Peliculas_PeliculasId",
                schema: "pelis",
                table: "PeliculaSalaDeCine");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaSalaDeCine_SalaDeCine_SalasDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine");

            migrationBuilder.RenameColumn(
                name: "SalasDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                newName: "SalaDeCineId");

            migrationBuilder.RenameColumn(
                name: "PeliculasId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                newName: "PeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_PeliculaSalaDeCine_SalasDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                newName: "IX_PeliculaSalaDeCine_SalaDeCineId");

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Actores",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Nombre" },
                values: new object[,]
                {
                    { 1, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 146, DateTimeKind.Local).AddTicks(4790), "Elijah Wood" },
                    { 2, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7691), "Idris Elba" },
                    { 3, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7739), "Rosalie Chiang" },
                    { 4, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7743), "Halle Berry" },
                    { 5, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7744), "Jessica Chastain" },
                    { 6, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7746), "Neve Campbell" },
                    { 7, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7748), "Jennifer Lopez" },
                    { 8, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7749), "Gal Gadot" },
                    { 9, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7751), "Tom Holland" },
                    { 10, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7753), "Robert Pattinson" },
                    { 11, "Bio here", new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7755), "Ryan Reynolds" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Cines",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[] { 3, "Multiplaza Cines", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (9.9 -83.98)") });

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaEstreno",
                value: new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Peliculas",
                columns: new[] { "Id", "EnCartelera", "FechaEstreno", "PosterUrl", "Titulo" },
                values: new object[,]
                {
                    { 4, false, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Moonfall" },
                    { 3, false, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Red" },
                    { 11, true, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "The Adam Project" },
                    { 10, true, new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "The Batman" },
                    { 9, false, new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Uncharted" },
                    { 5, false, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "The 355" },
                    { 7, false, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Marry Me" },
                    { 6, false, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Scream" },
                    { 8, true, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Death on the Nile" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "SalaDeCine",
                columns: new[] { "Id", "CineId", "Precio", "TipoSalaCine" },
                values: new object[,]
                {
                    { 11, 2, 3500m, "3D" },
                    { 2, 2, 3500m, "3D" },
                    { 4, 1, 3500m, "3D" },
                    { 5, 2, 3500m, "3D" },
                    { 7, 1, 3500m, "3D" },
                    { 8, 2, 3500m, "3D" },
                    { 10, 1, 3500m, "3D" },
                    { 1, 1, 3500m, "3D" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "PeliculaActores",
                columns: new[] { "ActorId", "PeliculaId", "Orden", "Personaje" },
                values: new object[,]
                {
                    { 1, 1, 1, "Frodo" },
                    { 11, 11, 1, "Adam Reed" },
                    { 9, 9, 1, "Nathan Drake" },
                    { 8, 8, 1, "Linnet Ridge" },
                    { 7, 7, 1, "Kat Valdez" },
                    { 6, 6, 1, "Ghostface" },
                    { 5, 5, 1, "Mace" },
                    { 10, 10, 1, "Batman" },
                    { 3, 3, 1, "Mei Lee" },
                    { 2, 2, 1, "Sonic" },
                    { 4, 4, 1, "Jocinda Fowler" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                columns: new[] { "PeliculaId", "SalaDeCineId" },
                values: new object[,]
                {
                    { 4, 10 },
                    { 9, 8 },
                    { 2, 8 },
                    { 8, 7 },
                    { 1, 7 },
                    { 6, 5 },
                    { 4, 4 },
                    { 2, 2 },
                    { 1, 1 },
                    { 11, 10 },
                    { 5, 5 },
                    { 5, 11 }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "SalaDeCine",
                columns: new[] { "Id", "CineId", "Precio", "TipoSalaCine" },
                values: new object[,]
                {
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
                    { 3, 3 },
                    { 7, 6 },
                    { 3, 9 },
                    { 10, 9 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaSalaDeCine_Peliculas_PeliculaId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                column: "PeliculaId",
                principalSchema: "pelis",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaSalaDeCine_SalaDeCine_SalaDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                column: "SalaDeCineId",
                principalSchema: "pelis",
                principalTable: "SalaDeCine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaSalaDeCine_Peliculas_PeliculaId",
                schema: "pelis",
                table: "PeliculaSalaDeCine");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaSalaDeCine_SalaDeCine_SalaDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine");

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
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "SalaDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                newName: "SalasDeCineId");

            migrationBuilder.RenameColumn(
                name: "PeliculaId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                newName: "PeliculasId");

            migrationBuilder.RenameIndex(
                name: "IX_PeliculaSalaDeCine_SalaDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                newName: "IX_PeliculaSalaDeCine_SalasDeCineId");

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaEstreno",
                value: new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaSalaDeCine_Peliculas_PeliculasId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                column: "PeliculasId",
                principalSchema: "pelis",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaSalaDeCine_SalaDeCine_SalasDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                column: "SalasDeCineId",
                principalSchema: "pelis",
                principalTable: "SalaDeCine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

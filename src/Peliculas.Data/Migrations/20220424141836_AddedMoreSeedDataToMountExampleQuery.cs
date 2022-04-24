using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Peliculas.Data.Migrations
{
    public partial class AddedMoreSeedDataToMountExampleQuery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 60, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 18, 35, 62, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Peliculas",
                columns: new[] { "Id", "EnCartelera", "FechaEstreno", "PosterUrl", "Titulo" },
                values: new object[,]
                {
                    { 18, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 7" },
                    { 17, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 6" },
                    { 16, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 5" },
                    { 15, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 4" },
                    { 14, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 3" },
                    { 13, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 2" },
                    { 19, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 8" },
                    { 12, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.dummyurl.com", "Other Movie 1" }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "PeliculaActores",
                columns: new[] { "ActorId", "PeliculaId", "Orden", "Personaje" },
                values: new object[,]
                {
                    { 1, 12, 1, "Elijah!" },
                    { 1, 13, 1, "Elijah!" },
                    { 1, 14, 1, "Elijah!" },
                    { 1, 15, 1, "Elijah!" },
                    { 1, 16, 1, "Elijah!" },
                    { 1, 17, 1, "Elijah!" },
                    { 1, 18, 1, "Elijah!" },
                    { 1, 19, 1, "Elijah!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 146, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 7, 34, 37, 147, DateTimeKind.Local).AddTicks(7755));
        }
    }
}

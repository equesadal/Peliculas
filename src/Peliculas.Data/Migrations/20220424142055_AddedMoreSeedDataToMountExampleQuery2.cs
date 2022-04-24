using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Peliculas.Data.Migrations
{
    public partial class AddedMoreSeedDataToMountExampleQuery2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 866, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                schema: "pelis",
                table: "Actores",
                keyColumn: "Id",
                keyValue: 11,
                column: "FechaNacimiento",
                value: new DateTime(2022, 4, 24, 8, 20, 54, 867, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                columns: new[] { "PeliculaId", "SalaDeCineId" },
                values: new object[,]
                {
                    { 18, 9 },
                    { 17, 9 },
                    { 16, 9 },
                    { 15, 9 },
                    { 14, 9 },
                    { 13, 9 },
                    { 19, 9 },
                    { 12, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

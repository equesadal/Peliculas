using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Peliculas.Data.Migrations
{
    public partial class DataSeedingForPeliculasAndCines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Cines",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[,]
                {
                    { 1, "Cinepolis Cartago", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (9.86 -83.95)") },
                    { 2, "Cinepolis Tres Rios", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (9.9 -83.98)") }
                });

            migrationBuilder.InsertData(
                schema: "pelis",
                table: "Peliculas",
                columns: new[] { "Id", "EnCartelera", "FechaEstreno", "PosterUrl", "Titulo" },
                values: new object[,]
                {
                    { "1", false, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.lordofrings-themovie.com", "Lord of Rings" },
                    { "2", true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.sonic2-themovie.com", "Sonic 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                schema: "pelis",
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}

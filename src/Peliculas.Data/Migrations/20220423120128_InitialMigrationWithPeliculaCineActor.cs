using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Peliculas.Data.Migrations
{
    public partial class InitialMigrationWithPeliculaCineActor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "pelis");

            migrationBuilder.CreateTable(
                name: "Actores",
                schema: "pelis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Biografia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cines",
                schema: "pelis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ubicacion = table.Column<Point>(type: "geography", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                schema: "pelis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EnCartelera = table.Column<bool>(type: "bit", nullable: false),
                    FechaEstreno = table.Column<DateTime>(type: "date", nullable: false),
                    PosterUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaActor",
                schema: "pelis",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    Personaje = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaActor", x => new { x.PeliculaId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_PeliculaActor_Actores_ActorId",
                        column: x => x.ActorId,
                        principalSchema: "pelis",
                        principalTable: "Actores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculaActor_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalSchema: "pelis",
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 1, false, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.lordofrings-themovie.com", "Lord of Rings" },
                    { 2, true, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.sonic2-themovie.com", "Sonic 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaActor_ActorId",
                schema: "pelis",
                table: "PeliculaActor",
                column: "ActorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cines",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "PeliculaActor",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "Actores",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "Peliculas",
                schema: "pelis");
        }
    }
}

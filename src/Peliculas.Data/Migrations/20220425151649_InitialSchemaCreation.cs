using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace Peliculas.Data.Migrations
{
    public partial class InitialSchemaCreation : Migration
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
                name: "CineOferta",
                schema: "pelis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "date", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "date", nullable: false),
                    PorcentajeDescuento = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    CineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CineOferta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                schema: "pelis",
                columns: table => new
                {
                    Identificador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Identificador);
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
                name: "Cines",
                schema: "pelis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ubicacion = table.Column<Point>(type: "geography", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cines_CineOferta_Id",
                        column: x => x.Id,
                        principalSchema: "pelis",
                        principalTable: "CineOferta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneroPelicula",
                schema: "pelis",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    GeneroIdentificador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroPelicula", x => new { x.PeliculaId, x.GeneroIdentificador });
                    table.ForeignKey(
                        name: "FK_GeneroPelicula_Generos_GeneroIdentificador",
                        column: x => x.GeneroIdentificador,
                        principalSchema: "pelis",
                        principalTable: "Generos",
                        principalColumn: "Identificador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroPelicula_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalSchema: "pelis",
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaActores",
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
                    table.PrimaryKey("PK_PeliculaActores", x => new { x.PeliculaId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_PeliculaActores_Actores_ActorId",
                        column: x => x.ActorId,
                        principalSchema: "pelis",
                        principalTable: "Actores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PeliculaActores_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalSchema: "pelis",
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalaDeCine",
                schema: "pelis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoSalaCine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    CineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaDeCine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalaDeCine_Cines_CineId",
                        column: x => x.CineId,
                        principalSchema: "pelis",
                        principalTable: "Cines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaSalaDeCine",
                schema: "pelis",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    SalaDeCineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaSalaDeCine", x => new { x.PeliculaId, x.SalaDeCineId });
                    table.ForeignKey(
                        name: "FK_PeliculaSalaDeCine_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalSchema: "pelis",
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PeliculaSalaDeCine_SalaDeCine_SalaDeCineId",
                        column: x => x.SalaDeCineId,
                        principalSchema: "pelis",
                        principalTable: "SalaDeCine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeneroPelicula_GeneroIdentificador",
                schema: "pelis",
                table: "GeneroPelicula",
                column: "GeneroIdentificador");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaActores_ActorId",
                schema: "pelis",
                table: "PeliculaActores",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaSalaDeCine_SalaDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                column: "SalaDeCineId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaDeCine_CineId",
                schema: "pelis",
                table: "SalaDeCine",
                column: "CineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneroPelicula",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "PeliculaActores",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "PeliculaSalaDeCine",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "Generos",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "Actores",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "Peliculas",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "SalaDeCine",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "Cines",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "CineOferta",
                schema: "pelis");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Peliculas.Data.Migrations
{
    public partial class FirstMigrationCreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "pelis");

            migrationBuilder.CreateTable(
                name: "Peliculas",
                schema: "pelis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: true),
                    EnCartelera = table.Column<bool>(nullable: false),
                    FechaEstreno = table.Column<DateTime>(nullable: false),
                    PosterUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas",
                schema: "pelis");
        }
    }
}

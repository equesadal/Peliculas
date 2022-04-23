using Microsoft.EntityFrameworkCore.Migrations;

namespace Peliculas.Data.Migrations
{
    public partial class AddedSalasDeCine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaActor_Actores_ActorId",
                schema: "pelis",
                table: "PeliculaActor");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaActor_Peliculas_PeliculaId",
                schema: "pelis",
                table: "PeliculaActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeliculaActor",
                schema: "pelis",
                table: "PeliculaActor");

            migrationBuilder.RenameTable(
                name: "PeliculaActor",
                schema: "pelis",
                newName: "PeliculaActores",
                newSchema: "pelis");

            migrationBuilder.RenameIndex(
                name: "IX_PeliculaActor_ActorId",
                schema: "pelis",
                table: "PeliculaActores",
                newName: "IX_PeliculaActores_ActorId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                schema: "pelis",
                table: "Cines",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeliculaActores",
                schema: "pelis",
                table: "PeliculaActores",
                columns: new[] { "PeliculaId", "ActorId" });

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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeliculaSalaDeCine",
                schema: "pelis",
                columns: table => new
                {
                    PeliculasId = table.Column<int>(type: "int", nullable: false),
                    SalasDeCineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculaSalaDeCine", x => new { x.PeliculasId, x.SalasDeCineId });
                    table.ForeignKey(
                        name: "FK_PeliculaSalaDeCine_Peliculas_PeliculasId",
                        column: x => x.PeliculasId,
                        principalSchema: "pelis",
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculaSalaDeCine_SalaDeCine_SalasDeCineId",
                        column: x => x.SalasDeCineId,
                        principalSchema: "pelis",
                        principalTable: "SalaDeCine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeliculaSalaDeCine_SalasDeCineId",
                schema: "pelis",
                table: "PeliculaSalaDeCine",
                column: "SalasDeCineId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaDeCine_CineId",
                schema: "pelis",
                table: "SalaDeCine",
                column: "CineId");

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaActores_Actores_ActorId",
                schema: "pelis",
                table: "PeliculaActores",
                column: "ActorId",
                principalSchema: "pelis",
                principalTable: "Actores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaActores_Peliculas_PeliculaId",
                schema: "pelis",
                table: "PeliculaActores",
                column: "PeliculaId",
                principalSchema: "pelis",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaActores_Actores_ActorId",
                schema: "pelis",
                table: "PeliculaActores");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculaActores_Peliculas_PeliculaId",
                schema: "pelis",
                table: "PeliculaActores");

            migrationBuilder.DropTable(
                name: "PeliculaSalaDeCine",
                schema: "pelis");

            migrationBuilder.DropTable(
                name: "SalaDeCine",
                schema: "pelis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeliculaActores",
                schema: "pelis",
                table: "PeliculaActores");

            migrationBuilder.RenameTable(
                name: "PeliculaActores",
                schema: "pelis",
                newName: "PeliculaActor",
                newSchema: "pelis");

            migrationBuilder.RenameIndex(
                name: "IX_PeliculaActores_ActorId",
                schema: "pelis",
                table: "PeliculaActor",
                newName: "IX_PeliculaActor_ActorId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                schema: "pelis",
                table: "Cines",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeliculaActor",
                schema: "pelis",
                table: "PeliculaActor",
                columns: new[] { "PeliculaId", "ActorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaActor_Actores_ActorId",
                schema: "pelis",
                table: "PeliculaActor",
                column: "ActorId",
                principalSchema: "pelis",
                principalTable: "Actores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculaActor_Peliculas_PeliculaId",
                schema: "pelis",
                table: "PeliculaActor",
                column: "PeliculaId",
                principalSchema: "pelis",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

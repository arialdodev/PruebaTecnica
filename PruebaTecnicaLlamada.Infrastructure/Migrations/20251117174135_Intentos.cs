using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaTecnicaLlamada.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Intentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Arranque = table.Column<int>(type: "int", nullable: false),
                    Envion = table.Column<int>(type: "int", nullable: false),
                    DeportistaId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Intentos_Deportistas_DeportistaId",
                        column: x => x.DeportistaId,
                        principalTable: "Deportistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Intentos_DeportistaId",
                table: "Intentos",
                column: "DeportistaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intentos");
        }
    }
}

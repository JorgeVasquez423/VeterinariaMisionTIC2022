using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria.App.Persistencia.Migrations
{
    public partial class CapaObetoMascota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuidadorId",
                table: "Mascotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_CuidadorId",
                table: "Mascotas",
                column: "CuidadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Personas_CuidadorId",
                table: "Mascotas",
                column: "CuidadorId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Personas_CuidadorId",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_CuidadorId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "CuidadorId",
                table: "Mascotas");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria.App.Persistencia.Migrations
{
    public partial class MigFluentfaltantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MascotaId",
                table: "SugerenciaCuidados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MascotaId",
                table: "HistoriaClinicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MascotaVacuna",
                columns: table => new
                {
                    MascotasId = table.Column<int>(type: "int", nullable: false),
                    VacunasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MascotaVacuna", x => new { x.MascotasId, x.VacunasId });
                    table.ForeignKey(
                        name: "FK_MascotaVacuna_Mascotas_MascotasId",
                        column: x => x.MascotasId,
                        principalTable: "Mascotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MascotaVacuna_Vacunas_VacunasId",
                        column: x => x.VacunasId,
                        principalTable: "Vacunas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SugerenciaCuidados_MascotaId",
                table: "SugerenciaCuidados",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinicas_MascotaId",
                table: "HistoriaClinicas",
                column: "MascotaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MascotaVacuna_VacunasId",
                table: "MascotaVacuna",
                column: "VacunasId");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriaClinicas_Mascotas_MascotaId",
                table: "HistoriaClinicas",
                column: "MascotaId",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SugerenciaCuidados_Mascotas_MascotaId",
                table: "SugerenciaCuidados",
                column: "MascotaId",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoriaClinicas_Mascotas_MascotaId",
                table: "HistoriaClinicas");

            migrationBuilder.DropForeignKey(
                name: "FK_SugerenciaCuidados_Mascotas_MascotaId",
                table: "SugerenciaCuidados");

            migrationBuilder.DropTable(
                name: "MascotaVacuna");

            migrationBuilder.DropIndex(
                name: "IX_SugerenciaCuidados_MascotaId",
                table: "SugerenciaCuidados");

            migrationBuilder.DropIndex(
                name: "IX_HistoriaClinicas_MascotaId",
                table: "HistoriaClinicas");

            migrationBuilder.DropColumn(
                name: "MascotaId",
                table: "SugerenciaCuidados");

            migrationBuilder.DropColumn(
                name: "MascotaId",
                table: "HistoriaClinicas");
        }
    }
}

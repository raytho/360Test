using Microsoft.EntityFrameworkCore.Migrations;

namespace clickmedic.Migrations
{
    public partial class UpdateToListAlergies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Alergias_alergiasAlergiaId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_alergiasAlergiaId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "alergiasAlergiaId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Alergias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alergias_UsuarioId",
                table: "Alergias",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alergias_Usuarios_UsuarioId",
                table: "Alergias",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alergias_Usuarios_UsuarioId",
                table: "Alergias");

            migrationBuilder.DropIndex(
                name: "IX_Alergias_UsuarioId",
                table: "Alergias");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Alergias");

            migrationBuilder.AddColumn<int>(
                name: "alergiasAlergiaId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_alergiasAlergiaId",
                table: "Usuarios",
                column: "alergiasAlergiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Alergias_alergiasAlergiaId",
                table: "Usuarios",
                column: "alergiasAlergiaId",
                principalTable: "Alergias",
                principalColumn: "AlergiaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

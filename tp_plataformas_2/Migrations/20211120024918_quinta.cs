using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carro_usuarios_UsuarioId",
                table: "carro");

            migrationBuilder.DropIndex(
                name: "IX_carro_UsuarioId",
                table: "carro");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_MiCarro",
                table: "usuarios",
                column: "MiCarro",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_carro_MiCarro",
                table: "usuarios",
                column: "MiCarro",
                principalTable: "carro",
                principalColumn: "CarroId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_carro_MiCarro",
                table: "usuarios");

            migrationBuilder.DropIndex(
                name: "IX_usuarios_MiCarro",
                table: "usuarios");

            migrationBuilder.CreateIndex(
                name: "IX_carro_UsuarioId",
                table: "carro",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_carro_usuarios_UsuarioId",
                table: "carro",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

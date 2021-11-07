using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Carro_CarroId",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_CarroId",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "CarroId",
                table: "Producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarroId",
                table: "Producto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CarroId",
                table: "Producto",
                column: "CarroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Carro_CarroId",
                table: "Producto",
                column: "CarroId",
                principalTable: "Carro",
                principalColumn: "CarroId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

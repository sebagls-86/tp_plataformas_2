using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class Initial_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Producto_ProductoId",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Carro_CarroId",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Carro_ProductoId",
                table: "Carro");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Carro");

            migrationBuilder.AlterColumn<int>(
                name: "CarroId",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Carro_CarroId",
                table: "Producto",
                column: "CarroId",
                principalTable: "Carro",
                principalColumn: "CarroId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Carro_CarroId",
                table: "Producto");

            migrationBuilder.AlterColumn<int>(
                name: "CarroId",
                table: "Producto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Carro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carro_ProductoId",
                table: "Carro",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Producto_ProductoId",
                table: "Carro",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Restrict);

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

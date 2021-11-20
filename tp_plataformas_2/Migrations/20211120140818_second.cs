using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_productos_carro_Id_Carro",
                table: "Carro_productos");

            migrationBuilder.DropForeignKey(
                name: "FK_CarroProducto_carro_CarroProductoCarroId",
                table: "CarroProducto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carro",
                table: "carro");

            migrationBuilder.RenameColumn(
                name: "CarroProductoCarroId",
                table: "CarroProducto",
                newName: "CarroProductoid");

            migrationBuilder.AlterColumn<int>(
                name: "CarroId",
                table: "carro",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "carro",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carro",
                table: "carro",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_productos_carro_Id_Carro",
                table: "Carro_productos",
                column: "Id_Carro",
                principalTable: "carro",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarroProducto_carro_CarroProductoid",
                table: "CarroProducto",
                column: "CarroProductoid",
                principalTable: "carro",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_productos_carro_Id_Carro",
                table: "Carro_productos");

            migrationBuilder.DropForeignKey(
                name: "FK_CarroProducto_carro_CarroProductoid",
                table: "CarroProducto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carro",
                table: "carro");

            migrationBuilder.DropColumn(
                name: "id",
                table: "carro");

            migrationBuilder.RenameColumn(
                name: "CarroProductoid",
                table: "CarroProducto",
                newName: "CarroProductoCarroId");

            migrationBuilder.AlterColumn<int>(
                name: "CarroId",
                table: "carro",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carro",
                table: "carro",
                column: "CarroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_productos_carro_Id_Carro",
                table: "Carro_productos",
                column: "Id_Carro",
                principalTable: "carro",
                principalColumn: "CarroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarroProducto_carro_CarroProductoCarroId",
                table: "CarroProducto",
                column: "CarroProductoCarroId",
                principalTable: "carro",
                principalColumn: "CarroId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos_compra",
                table: "Productos_compra");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Productos_compra",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos_compra",
                table: "Productos_compra",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_compra_Id_producto",
                table: "Productos_compra",
                column: "Id_producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos_compra",
                table: "Productos_compra");

            migrationBuilder.DropIndex(
                name: "IX_Productos_compra_Id_producto",
                table: "Productos_compra");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Productos_compra",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos_compra",
                table: "Productos_compra",
                columns: new[] { "Id_producto", "Id_compra" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class sexta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_productos_carro_Id_Carro",
                table: "Carro_productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carro",
                table: "carro");

            migrationBuilder.DropColumn(
                name: "id",
                table: "carro");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_productos_carro_Id_Carro",
                table: "Carro_productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carro",
                table: "carro");

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
        }
    }
}

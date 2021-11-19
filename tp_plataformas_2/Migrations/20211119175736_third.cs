﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarroProducto");

            migrationBuilder.DropTable(
                name: "CompraProducto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carro_productos",
                table: "Carro_productos");

            migrationBuilder.DropIndex(
                name: "IX_Carro_productos_Id_Producto",
                table: "Carro_productos");

            migrationBuilder.AlterColumn<int>(
                name: "Carro_productos_Id",
                table: "Carro_productos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carro_productos",
                table: "Carro_productos",
                columns: new[] { "Id_Producto", "Id_Carro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carro_productos",
                table: "Carro_productos");

            migrationBuilder.AlterColumn<int>(
                name: "Carro_productos_Id",
                table: "Carro_productos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carro_productos",
                table: "Carro_productos",
                column: "Carro_productos_Id");

            migrationBuilder.CreateTable(
                name: "CarroProducto",
                columns: table => new
                {
                    CarroProductoCarroId = table.Column<int>(type: "int", nullable: false),
                    ProductosCompraProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarroProducto", x => new { x.CarroProductoCarroId, x.ProductosCompraProductoId });
                    table.ForeignKey(
                        name: "FK_CarroProducto_carro_CarroProductoCarroId",
                        column: x => x.CarroProductoCarroId,
                        principalTable: "carro",
                        principalColumn: "CarroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarroProducto_productos_ProductosCompraProductoId",
                        column: x => x.ProductosCompraProductoId,
                        principalTable: "productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompraProducto",
                columns: table => new
                {
                    CompraProductoCompraId = table.Column<int>(type: "int", nullable: false),
                    CompraProductoProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraProducto", x => new { x.CompraProductoCompraId, x.CompraProductoProductoId });
                    table.ForeignKey(
                        name: "FK_CompraProducto_compras_CompraProductoCompraId",
                        column: x => x.CompraProductoCompraId,
                        principalTable: "compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompraProducto_productos_CompraProductoProductoId",
                        column: x => x.CompraProductoProductoId,
                        principalTable: "productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carro_productos_Id_Producto",
                table: "Carro_productos",
                column: "Id_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_CarroProducto_ProductosCompraProductoId",
                table: "CarroProducto",
                column: "ProductosCompraProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_CompraProducto_CompraProductoProductoId",
                table: "CompraProducto",
                column: "CompraProductoProductoId");
        }
    }
}

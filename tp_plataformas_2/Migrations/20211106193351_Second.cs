using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuil = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: true),
                    Mail = table.Column<string>(type: "varchar(50)", nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", nullable: true),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompradorUsuarioId = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<double>(type: "double", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Compra_Usuarios_CompradorUsuarioId",
                        column: x => x.CompradorUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    CarroId = table.Column<int>(type: "int", nullable: true),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CatId",
                        column: x => x.CatId,
                        principalTable: "Categorias",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    CarroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioForeingKey = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.CarroId);
                    table.ForeignKey(
                        name: "FK_Carro_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carro_Usuarios_UsuarioForeingKey",
                        column: x => x.UsuarioForeingKey,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompraProducto",
                columns: table => new
                {
                    CompraProductoCompraId = table.Column<int>(type: "int", nullable: false),
                    productosCompraProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraProducto", x => new { x.CompraProductoCompraId, x.productosCompraProductoId });
                    table.ForeignKey(
                        name: "FK_CompraProducto_Compra_CompraProductoCompraId",
                        column: x => x.CompraProductoCompraId,
                        principalTable: "Compra",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompraProducto_Productos_productosCompraProductoId",
                        column: x => x.productosCompraProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carro_ProductoId",
                table: "Carro",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_UsuarioForeingKey",
                table: "Carro",
                column: "UsuarioForeingKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Compra_CompradorUsuarioId",
                table: "Compra",
                column: "CompradorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CompraProducto_productosCompraProductoId",
                table: "CompraProducto",
                column: "productosCompraProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CarroId",
                table: "Productos",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CatId",
                table: "Productos",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Carro_CarroId",
                table: "Productos",
                column: "CarroId",
                principalTable: "Carro",
                principalColumn: "CarroId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Productos_ProductoId",
                table: "Carro");

            migrationBuilder.DropTable(
                name: "CompraProducto");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}

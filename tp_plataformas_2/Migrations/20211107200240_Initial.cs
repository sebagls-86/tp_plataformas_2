using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
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
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CatId",
                        column: x => x.CatId,
                        principalTable: "Categoria",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    CarroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.CarroId);
                    table.ForeignKey(
                        name: "FK_Carro_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Compra_Usuario_CompradorUsuarioId",
                        column: x => x.CompradorUsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carro_productos",
                columns: table => new
                {
                    Carro_productos_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Carro = table.Column<int>(type: "int", nullable: false),
                    Id_Producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro_productos", x => x.Carro_productos_Id);
                    table.ForeignKey(
                        name: "FK_Carro_productos_Carro_Id_Carro",
                        column: x => x.Id_Carro,
                        principalTable: "Carro",
                        principalColumn: "CarroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carro_productos_Producto_Id_Producto",
                        column: x => x.Id_Producto,
                        principalTable: "Producto",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compras_Carro",
                columns: table => new
                {
                    CarroProductoCarroId = table.Column<int>(type: "int", nullable: false),
                    ProductosCompraProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras_Carro", x => new { x.CarroProductoCarroId, x.ProductosCompraProductoId });
                    table.ForeignKey(
                        name: "FK_Compras_Carro_Carro_CarroProductoCarroId",
                        column: x => x.CarroProductoCarroId,
                        principalTable: "Carro",
                        principalColumn: "CarroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Carro_Producto_ProductosCompraProductoId",
                        column: x => x.ProductosCompraProductoId,
                        principalTable: "Producto",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompraProducto",
                columns: table => new
                {
                    CompraProductoCompraId = table.Column<int>(type: "int", nullable: false),
                    productosProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraProducto", x => new { x.CompraProductoCompraId, x.productosProductoId });
                    table.ForeignKey(
                        name: "FK_CompraProducto_Compra_CompraProductoCompraId",
                        column: x => x.CompraProductoCompraId,
                        principalTable: "Compra",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompraProducto_Producto_productosProductoId",
                        column: x => x.productosProductoId,
                        principalTable: "Producto",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos_compra",
                columns: table => new
                {
                    Productos_compra_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Compra = table.Column<int>(type: "int", nullable: false),
                    Id_Producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos_compra", x => x.Productos_compra_Id);
                    table.ForeignKey(
                        name: "FK_Productos_compra_Compra_Id_Compra",
                        column: x => x.Id_Compra,
                        principalTable: "Compra",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_compra_Producto_Id_Producto",
                        column: x => x.Id_Producto,
                        principalTable: "Producto",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carro_UsuarioId",
                table: "Carro",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carro_productos_Id_Carro",
                table: "Carro_productos",
                column: "Id_Carro");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_productos_Id_Producto",
                table: "Carro_productos",
                column: "Id_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_CompradorUsuarioId",
                table: "Compra",
                column: "CompradorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CompraProducto_productosProductoId",
                table: "CompraProducto",
                column: "productosProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_Carro_ProductosCompraProductoId",
                table: "Compras_Carro",
                column: "ProductosCompraProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CatId",
                table: "Producto",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_compra_Id_Compra",
                table: "Productos_compra",
                column: "Id_Compra");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_compra_Id_Producto",
                table: "Productos_compra",
                column: "Id_Producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carro_productos");

            migrationBuilder.DropTable(
                name: "CompraProducto");

            migrationBuilder.DropTable(
                name: "Compras_Carro");

            migrationBuilder.DropTable(
                name: "Productos_compra");

            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}

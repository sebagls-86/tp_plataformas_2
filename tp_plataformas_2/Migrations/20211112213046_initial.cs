using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carro",
                columns: table => new
                {
                    CarroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carro", x => x.CarroId);
                });

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuil = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false),
                    MiCarro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_usuarios_carro_MiCarro",
                        column: x => x.MiCarro,
                        principalTable: "carro",
                        principalColumn: "CarroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_productos_categorias_CatId",
                        column: x => x.CatId,
                        principalTable: "categorias",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Carro_productos_carro_Id_Carro",
                        column: x => x.Id_Carro,
                        principalTable: "carro",
                        principalColumn: "CarroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carro_productos_productos_Id_Producto",
                        column: x => x.Id_Producto,
                        principalTable: "productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                   
                    //ProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compras", x => x.CompraId);
                    //table.ForeignKey(
                    //    name: "FK_compras_productos_ProductoId",
                    //    column: x => x.ProductoId,
                    //    principalTable: "productos",
                    //    principalColumn: "ProductoId",
                    //    onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_compras_usuarios_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos_compra",
                columns: table => new
                {
                    Id_compra = table.Column<int>(type: "int", nullable: false),
                    Id_producto = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Cantidad_producto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos_compra", x => new { x.Id_producto, x.Id_compra });
                    table.ForeignKey(
                        name: "FK_Productos_compra_compras_Id_compra",
                        column: x => x.Id_compra,
                        principalTable: "compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_compra_productos_Id_producto",
                        column: x => x.Id_producto,
                        principalTable: "productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carro_productos_Id_Carro",
                table: "Carro_productos",
                column: "Id_Carro");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_productos_Id_Producto",
                table: "Carro_productos",
                column: "Id_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_CarroProducto_ProductosCompraProductoId",
                table: "CarroProducto",
                column: "ProductosCompraProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_compras_idUsuario",
                table: "compras",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_compras_ProductoId",
                table: "compras",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_CatId",
                table: "productos",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_compra_Id_compra",
                table: "Productos_compra",
                column: "Id_compra");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_MiCarro",
                table: "usuarios",
                column: "MiCarro",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carro_productos");

            migrationBuilder.DropTable(
                name: "CarroProducto");

            migrationBuilder.DropTable(
                name: "Productos_compra");

            migrationBuilder.DropTable(
                name: "compras");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "carro");
        }
    }
}

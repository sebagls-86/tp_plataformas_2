using Microsoft.EntityFrameworkCore.Migrations;

namespace tp_plataformas_2.Migrations
{
    public partial class Initial_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Productos_ProductoId",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Usuarios_UsuarioForeingKey",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Usuarios_CompradorUsuarioId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_CompraProducto_Productos_productosCompraProductoId",
                table: "CompraProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Carro_CarroId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CatId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_CatId",
                table: "Producto",
                newName: "IX_Producto_CatId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_CarroId",
                table: "Producto",
                newName: "IX_Producto_CarroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Producto_ProductoId",
                table: "Carro",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Usuario_UsuarioForeingKey",
                table: "Carro",
                column: "UsuarioForeingKey",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Usuario_CompradorUsuarioId",
                table: "Compra",
                column: "CompradorUsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompraProducto_Producto_productosCompraProductoId",
                table: "CompraProducto",
                column: "productosCompraProductoId",
                principalTable: "Producto",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Carro_CarroId",
                table: "Producto",
                column: "CarroId",
                principalTable: "Carro",
                principalColumn: "CarroId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria_CatId",
                table: "Producto",
                column: "CatId",
                principalTable: "Categoria",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Producto_ProductoId",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Usuario_UsuarioForeingKey",
                table: "Carro");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Usuario_CompradorUsuarioId",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_CompraProducto_Producto_productosCompraProductoId",
                table: "CompraProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Carro_CarroId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria_CatId",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_CatId",
                table: "Productos",
                newName: "IX_Productos_CatId");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_CarroId",
                table: "Productos",
                newName: "IX_Productos_CarroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Productos_ProductoId",
                table: "Carro",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Usuarios_UsuarioForeingKey",
                table: "Carro",
                column: "UsuarioForeingKey",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Usuarios_CompradorUsuarioId",
                table: "Compra",
                column: "CompradorUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompraProducto_Productos_productosCompraProductoId",
                table: "CompraProducto",
                column: "productosCompraProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Carro_CarroId",
                table: "Productos",
                column: "CarroId",
                principalTable: "Carro",
                principalColumn: "CarroId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CatId",
                table: "Productos",
                column: "CatId",
                principalTable: "Categorias",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

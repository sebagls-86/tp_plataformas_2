using System;
using System.Collections.Generic;
using System.Text;

namespace tp_plataformas_2
{
    public class Productos_compra
    {
        public int Id_compra { get; set; }
        public int Id_producto { get; set; }
        public int Cantidad_producto { get; set; }
        public Compra Compra { get; set; }
        public Producto Producto { get; set; }

        public Productos_compra() {}
               
        public Productos_compra(int idCompra, int idProducto, int cantidadProducto)
        {
            Id_compra = idCompra;
            Id_producto = idProducto;
            Cantidad_producto = cantidadProducto;
        }

        public Productos_compra(Producto producto, Compra compra, int cantidadProducto)
        {
            Producto = producto;
            Compra = compra;
            Cantidad_producto = cantidadProducto;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace tp_plataformas_2
{
    public class Productos_compra
    {
        public int Id { get; set; }
        public int Id_compra { get; set; }
        public int Id_producto { get; set; }
        public int Cantidad_producto { get; set; }
        public Compra Compra { get; set; }
        public Producto Producto { get; set; }

        public Productos_compra() {}
               
    }
}

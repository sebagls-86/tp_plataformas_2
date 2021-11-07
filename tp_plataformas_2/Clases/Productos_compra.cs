using System;
using System.Collections.Generic;
using System.Text;

namespace tp_plataformas_2
{
    public class Productos_compra
    {
        public int Productos_compra_Id { get; set; }
        public int Id_Compra { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }

        public Compra Compra { get; set; }
        public Producto Producto { get; set; }


        public Productos_compra()
        {
            
        }

        
    }
}

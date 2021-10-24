using System;
using System.Collections.Generic;
using System.Text;

namespace tp_plataformas_2
{
    public class CompraRealizada
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public Usuario Comprador;
        public string Productos { get; set; }
        public Double Total { get; set; }

        public CompraRealizada(int _Id, Usuario usuario, Double total, Dictionary<Producto, int> productos)
        {
            Id = _Id;
            Comprador = usuario;
            Total = total;
            Usuario = usuario.Nombre;
            Productos = creaProducto(productos);
        }

        public string creaProducto(Dictionary<Producto, int> productos)
        {
            string miString = "";
            foreach (Producto prod in productos.Keys)
            {
                miString += $" {prod.Nombre} - {productos[prod]}\n ";
            }
            return miString;
        }
    }
}

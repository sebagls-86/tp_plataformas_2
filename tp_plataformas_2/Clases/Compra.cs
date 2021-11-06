using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace tp_plataformas_2
{
    public class Compra : IComparable<Compra>
    {
        public int CompraId { get; set; }
        public Usuario Comprador { get; set; }

        [NotMapped]
        public Dictionary<Producto, int> Productos { get; set; }
        public Double Total { get; set; }

        [NotMapped]
        public List<Producto> productos { get; set; }

        public ICollection<Producto> productosCompra { get; set; }

        public int IdProducto { get; set; }


        public Compra(int _Id, Usuario usuario, Dictionary<Producto, int> productos, Double total)
        {
            CompraId = _Id;
            Comprador = usuario;
            Productos = productos;
            Total = total;
        }

        public Compra()
        {
            
        }

        public int CompareTo(Compra other)
        {
            return CompraId.CompareTo(other.CompraId);
        }
        
        private string compraRealizada()
        {
            string suma = "";
            foreach(Producto prod in Productos.Keys){
                int cantComprada = Productos[prod];
                suma += "*" + cantComprada +"|"+ prod.ProductoId + "|" + prod.Nombre + "|" + prod.Precio +"|" + prod.Cat + "|" + prod.Cantidad;

            }
            //idcompra idusuario idprod
            return suma;
        }
         
        public override string ToString()
        {
            return $"{CompraId}|{Comprador.UsuarioId}|{Total}{compraRealizada()}";
        }
    }
}

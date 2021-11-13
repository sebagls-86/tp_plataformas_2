using System;
using System.Collections.Generic;


namespace tp_plataformas_2
{
    public class Compra : IComparable<Compra>
    {
        public int CompraId { get; set; }
        public Usuario Usuario { get; set; }
        public int idUsuario { get; set; }
        public Double Total { get; set; }
        public List<Productos_compra> Productos_compra { get; set; }
        
       
        public Compra() { }

        public Compra(int _Id, Usuario usuario, Double total)
        {
            CompraId = _Id;
            Usuario = usuario;
            Total = total;
        }

        public Compra (int usuarioId, double total)
        {
            this.idUsuario = usuarioId;
            this.Total = total;
        }

        public int CompareTo(Compra other)
        {
            return CompraId.CompareTo(other.CompraId);
        }

        //private string CompraRealizada()
        //{
        //    string suma = "";
        //    foreach (Producto prod in Productos.Keys)
        //    {
        //        int cantComprada = Productos[prod];
        //        suma += "*" + cantComprada + "|" + prod.ProductoId + "|" + prod.Nombre + "|" + prod.Precio + "|" + prod.Cat + "|" + prod.Cantidad;

        //    }
        //    //idcompra idusuario idprod
        //    return suma;
        //}

        public override string ToString()
        {
            return $"{CompraId}|{Usuario.UsuarioId}|{Total}";
        }
    }
}

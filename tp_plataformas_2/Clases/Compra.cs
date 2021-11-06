using System;
using System.Collections.Generic;


namespace tp_plataformas_2
{
    public class Compra : IComparable<Compra>
    {
        public int Id { get; set; }
        public Usuario Comprador { get; set; }
        public Dictionary<Producto, int> Productos { get; set; }
        public Double Total { get; set; }

        public Compra(int _Id, Usuario usuario, Dictionary<Producto, int> productos, Double total)
        {
            Id = _Id;
            Comprador = usuario;
            Productos = productos;
            Total = total;
        }

        public int CompareTo(Compra other)
        {
            return Id.CompareTo(other.Id);
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
            return $"{Id}|{Comprador.UsuarioId}|{Total}{compraRealizada()}";
        }
    }
}

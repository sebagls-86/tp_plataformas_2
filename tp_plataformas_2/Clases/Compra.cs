using System;
using System.Collections.Generic;


namespace tp_plataformas_2
{
    public class Compra : IComparable<Compra>
    {
        public int Id { get; set; }
        public Usuario Comprador;
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

        public override string ToString()
        {
            return $"{Id}|{Comprador.Id}|{Productos.Keys}|{Productos.Values}|{Total}";
        }
    }
}

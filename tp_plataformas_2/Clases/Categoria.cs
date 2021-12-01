using System;
using System.Collections.Generic;

namespace tp_plataformas_2
{
    public class Categoria : IComparable<Categoria>
    {
        public int CatId { get; set; }
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; } = new List<Producto>();

        public Categoria() {}
        public Categoria(string nombre)
        {
            
            Nombre = nombre;
        }


        public int CompareTo(Categoria other)
        {
            return Nombre.CompareTo(other.Nombre);
        }

        public override string ToString()
        {
            return $"{CatId}|{Nombre}";
        }

        public string[] toArray()
        {
            return new string[] { CatId.ToString(), Nombre.ToString() };
        }
    }
}

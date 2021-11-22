using System;
using System.Collections.Generic;


namespace tp_plataformas_2
{
    public class Carro
    {

        public int id { get; set; }
        public int CarroId { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public ICollection<Producto> ProductosCompra { get; set; } = new List<Producto>();
        public List<Carro_productos> Carro_productos { get; set; }
        
        public Carro(int id, int usuarioId)
        {
            CarroId = id;
            UsuarioId = usuarioId;
        }

        public Carro() { }

       

    }
}

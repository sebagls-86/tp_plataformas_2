

namespace tp_plataformas_2
{
    public class Carro_productos
    {
        public int Carro_productos_Id { get; set; }
        public Carro Carro { get; set; }
        public int Id_Carro { get; set; }
        public Producto Producto { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public Carro_productos() { }

    }
}

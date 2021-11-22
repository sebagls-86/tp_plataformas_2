

namespace tp_plataformas_2
{
    public class Carro_productos
    {
        //public int Carro_productos_Id { get; set; }
        public Carro Carro { get; set; }
        public int Id_Carro { get; set; }
        public Producto Producto { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public Carro_productos() { }

        public Carro_productos(int id_Carro, int id_producto, int cantidad, Producto producto)
        {
            
            Id_Carro = id_Carro;
            Id_Producto = id_producto;
            Cantidad = cantidad;
            Producto = producto;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace tp_plataformas_2
{


    public class Mercado
    {
        public List<Producto> productos { get; set; }
        public List<Usuario> usuarios { get; set; }
        public Categoria[] categorias { get; set; }
        public readonly double IVA = 21;

        public List<Compra> compras { get; set; }

        const int maxCategorias = 10;

        int cantCategorias = 0;
        int cantProductos = 0; 
        /* --- Variables auxiliares  ---*/

        private string[] contenidos = new string[10];


        public Mercado()
        {
            productos = new List<Producto>();
            usuarios = new List<Usuario>();
            compras = new List<Compra>();
            compras.Add(null);
            categorias = new Categoria[maxCategorias];
             
            FileManager.CreateFolder();
            
            FileManager.CreateFile("categorias");
            FileManager.CreateFile("productos");
            FileManager.CreateFile("compras");
            FileManager.CreateFile("usuarios");

            ObtenerCategorias();
            ReadFileUsuarios();
            ReadFileProductos();
        }

        private void ObtenerCategorias()
        {
            contenidos = FileManager.ReadFileCategorias();
            foreach (string contenido in contenidos)
            {
                if (contenido != null && contenido != "")
                {
                    AgregarCategoria(contenido);
                }

            }

        }
        private void ReadFileUsuarios()
        {
            contenidos = FileManager.ReadFileUsuarios();
            char delimiterChars = '|';

            foreach (string contenido in contenidos)
            {
                if (contenido != null && contenido != "")
                {
                    string[] propiedades = contenido.Split(delimiterChars);

                    
                    int cuil = int.Parse(propiedades[1]);
                    string nombre = propiedades[2];
                    string apellido = propiedades[3];
                    string mail = propiedades[4];
                    string password = propiedades[5];
                    int tipoUsuario = int.Parse(propiedades[6]);
                    AgregarUsuario(cuil, nombre, apellido, mail, password, tipoUsuario);
                }

            }

        }
        private void ReadFileProductos()
        {
            contenidos = FileManager.ReadFileProductos();
            char delimiterChars = '|';

            foreach (string contenido in contenidos)
            {
                if (contenido != null && contenido != "")
                {
                    string[] propiedades = contenido.Split(delimiterChars);
                    

                    int Id = int.Parse(propiedades[0]);
                    string nombre = propiedades[1];
                    double precio = double.Parse(propiedades[2]);
                    int cantidad = int.Parse(propiedades[3]);
                    int idCat = int.Parse(propiedades[4]);
                    string categoriaNombre = propiedades[5];

                    AgregarProducto(nombre, precio, cantidad, idCat);

                    
                }

            }

        }
        public bool AgregarProducto(string nombre, double precio, int Cantidad, int idCategoria)//Creamos producto y lo agregamos al array list de productos
        {
            int indice = idCategoria - 1;
            if (categorias[indice] != null && categorias[indice].Id == idCategoria)
            {
                Producto producto = new Producto(cantProductos, nombre, precio, Cantidad, categorias[indice]);
                this.productos.Add(producto);
                FileManager.SaveListProductos(productos);
                cantProductos++;
                return true;
            }

            return false;
            
        }

        public bool ModificarProducto(int ID, string Nombre, double Precio, int Cantidad, int ID_Categoria)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].Id == ID)
                {
                    productos[i].Nombre = Nombre;
                    productos[i].Precio = Precio;
                    productos[i].Cantidad = Cantidad;
                    productos[i].Id = ID;
                    //productos[i].Cat = productos[ID_Categoria-1].Cat; // :)
                    productos[i].Cat = categorias[ID_Categoria - 1];
                    Console.WriteLine("Producto modificado con éxito " + Nombre + Precio + Cantidad + ID);
                }
            }

            return true;
        }

        public bool EliminarProducto(int id)
        {
            bool encontre = false;
            int i = 0;
            while (!encontre && i < productos.Count)
            {
                encontre = productos[i].Id == id;
                if (encontre)
                {

                    productos.Remove(productos[i]);
                    FileManager.SaveListProductos(productos);
                }
                else
                    i++;
            }
            return encontre;
        }




        public void BuscarProductos(String Query)
        {
            List<Producto> productosBuscados = new List<Producto>();

            foreach (Producto producto in productos)
            {
                if (producto.Nombre.Contains(Query))
                {

                    productosBuscados.Add(producto);
                }

            }

            productos.Sort();

            foreach (Producto p in productos)
            {
                Console.WriteLine(p);
            }


        }

        public Producto BuscarProductoPorId(String Id)
        {
            Producto producto;
            bool sePudoParsear = Int32.TryParse(Id, out int idProducto);
            if (!sePudoParsear)
            {
                throw new Excepciones("No se pudo parsear el ID del producto buscado.");
            } else if (MercadoHelper.SonMenoresACero(new List<int> { idProducto }))
            {
                throw new Excepciones("El indice del producto que quiere buscar es menor a 0.");
            } else if (!MercadoHelper.ExisteElProducto(idProducto,productos))
            {
                throw new Excepciones("No existe el producto con ID " + idProducto);
            } else
            {
                producto = productos[idProducto];
            }
            
            return producto;
        }


        public void BuscarProductosPorPrecio(String Query)
        {
            List<Producto> productosBuscados = new List<Producto>();

            foreach (Producto producto in productos)
            {
                if (producto.Nombre.Contains(Query))
                {

                    productosBuscados.Add(producto);
                }

            }
            var ordenada = productosBuscados.OrderByDescending(producto => producto.Precio);
            foreach (Producto p in ordenada)
            {

                Console.WriteLine("{0} - {1}", p.Nombre, p.Precio);

            }

        }

        public void BuscarProductosPorCategoria(int ID_Categoria)
        {

            foreach (Producto producto in productos)
            {
                if (producto.Cat.Id == ID_Categoria)
                {
                    productos.Sort();
                    Console.WriteLine(producto);
                }

            }

        }


        public bool AgregarUsuario(int cuil, String nombre, String apellido, String mail, String password, int tipoUsuario)
        {

            foreach(Usuario persona in usuarios)
            {
                if(persona.Cuil == cuil)
                {
                    return false;
                }

            }


            int id = usuarios.Count + 1;
            Carro micarro = new Carro(id);
           
                Usuario usuario = new Usuario(id, cuil, nombre, apellido, mail, password, micarro, tipoUsuario);
                usuarios.Add(usuario);
                FileManager.SaveListUsuarios(usuarios);
                Console.WriteLine("La empresa fue creada con exito");
            

            
            
            return true;

        }
        public bool ModificarUsuario(int ID, String nombre, String apellido, String mail, String password, int tipoUsuario)
        {

            bool encontre = false;
            int i = 0;
            int id = ID - 1;
            while (!encontre && i < usuarios.Count)
            {
                encontre = usuarios[i].Id == id;
                if (encontre)
                {

                    usuarios[id].Nombre = nombre;
                    usuarios[id].Apellido = apellido;
                    usuarios[id].Mail = mail;
                    usuarios[ID].Password = password;
                    usuarios[ID].TipoUsuario = tipoUsuario;

                    FileManager.SaveListUsuarios(usuarios);
                }
                else
                    i++;
            }
            return encontre;


            
        }



        public bool EliminarUsuario(int id)
        {
            bool encontre = false;
            int i = 0;
            while (!encontre && i < usuarios.Count)
            {
                encontre = usuarios[i].Id == id;
                if (encontre)
                {

                    usuarios.Remove(usuarios[i]);
                    
                    FileManager.SaveListUsuarios(usuarios);
                }
                else
                    i++;
            }
            return encontre;
        }


        public List<Usuario> MostrarUsuarios()
        {
            
                usuarios.Sort();
             

            return usuarios;
        }

        private bool BuscarCategoria(int ID)
        {
            foreach(Categoria categoria in categorias)
            {
                if(categoria == null)
                {
                    return true;
                }
            }
            return false;
        }
        public bool AgregarCategoria(string nombre) //Agregamos una categoria al array de categorias
        {
            foreach (Categoria categoria in categorias)
            {
                if (categoria != null)
                {
                    if (categoria.Nombre.Equals(" "))
                    {
                        categoria.Nombre = nombre;
                        break;
                    }
                }
            }
            if (cantCategorias <= maxCategorias)

            {
                int id = cantCategorias + 1;
                if (BuscarCategoria(id))
                {
                    Categoria categoria = new Categoria(id, nombre);

                    int auxiliar = 0;
                    int j = 0;

                    do
                    {
                        if (categorias[j] == null)
                        {
                            cantCategorias++;
                            categorias[j] = categoria;
                            auxiliar = 1;
                        }
                        j++;

                    } while (auxiliar == 0);
                }





                FileManager.SaveArrayCategorias(categorias);
                return true;

            }

            return false;
        }

        public bool ModificarCategoria(int ID, string Nombre)
        {
            ID = ID - 1;
            if (categorias[ID] != null)
            {
                categorias[ID].Nombre = Nombre;
                FileManager.SaveArrayCategorias(categorias);
            }
            else
            {
                return false;
            }


            return true;
        }

        public bool EliminarCategoria(int ID)
        {
            bool encontre = false;
            int i = 0;
            while (!encontre && i < categorias.Length)
            {
                if (categorias[i] != null)
                {
                    encontre = categorias[i].Id == ID;

                }
                if (encontre)
                {

                    categorias[i].Nombre = " ";
                    Console.WriteLine("Categoria " + ID + " eliminada con éxito!");
                    FileManager.SaveArrayCategorias(categorias);
                    //cantCategorias--;
                }

                i++;
            }
            return encontre;
        }



        public bool BuscarCategoria(string Nombre)
        {
            foreach (Categoria categoria in categorias)
            {
                if (categoria.Nombre.Equals(Nombre))
                {
                    Console.WriteLine(categoria.Nombre);
                }

               
            }
            return true;
        }

        public Categoria[] MostrarCategorias()
        {
            
            return categorias;
        }

        public bool AgregarAlCarro(int Id_Producto, int Cantidad, int Id_Usuario)
        {
            bool sePudoAgregar = false;
            Usuario usuarioEncontrado;
            Producto productoEncontrado;
            if (MercadoHelper.SonMenoresACero(new List<int> { Id_Producto, Cantidad, Id_Usuario }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(Id_Usuario, usuarios))
            {
                Console.WriteLine("El usuario con id {0} no se pudo encontrar", Id_Usuario);
            }
            else if (!MercadoHelper.ExisteElProducto(Id_Producto, productos))
            {
                Console.WriteLine("El producto con id {0} no se pudo encontrar", Id_Producto);
            }
            else
            {
                usuarioEncontrado = usuarios[Id_Usuario];
                productoEncontrado = productos[Id_Producto];
                if (Cantidad > productoEncontrado.Cantidad)
                {
                    Console.WriteLine("La cantidad que se quiere agregar es mayor al stock disponible.");
                }
                else
                {
                    usuarioEncontrado.MiCarro.AgregarProducto(productoEncontrado, Cantidad);

                    sePudoAgregar = true;

                    Console.WriteLine("El producto {0} con cantidad {1} se ha añadido al carro del usuario {2}.", productoEncontrado.Nombre, Cantidad, usuarioEncontrado.Nombre);

                }
            }
            return sePudoAgregar;
        }

        public bool QuitarDelCarro(int Id_Producto, int Cantidad, int Id_Usuario)
        {
            bool sePudoDisminuir = false;
            Usuario usuarioEncontrado;
            Producto productoEncontrado;
            if (MercadoHelper.SonMenoresACero(new List<int> { Id_Producto, Cantidad, Id_Usuario }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(Id_Usuario, usuarios))
            {
                Console.WriteLine("El usuario con id {0} no se pudo encontrar", Id_Usuario);
            }
            else if (!MercadoHelper.ExisteElProducto(Id_Producto, productos))
            {
                Console.WriteLine("El producto con id {0} no se pudo encontrar", Id_Producto);
            }
            else
            {
                usuarioEncontrado = usuarios[Id_Usuario];
                productoEncontrado = productos[Id_Producto];
                if (!usuarioEncontrado.MiCarro.Productos.ContainsKey(productoEncontrado))
                {
                    Console.WriteLine("El producto {0} no se encuentra en el carro de {1}.", productoEncontrado, usuarioEncontrado.Nombre);
                }
                else if (usuarioEncontrado.MiCarro.Productos[productoEncontrado] < Cantidad || Cantidad == 0)
                {
                    usuarioEncontrado.MiCarro.RemoverProducto(productoEncontrado, Cantidad);
                    Console.WriteLine("El producto {0} ha sido removido en su totalidad del carro del usuario {1}.", productoEncontrado.Nombre, usuarioEncontrado.Nombre);
                }
                else
                {
                    usuarioEncontrado.MiCarro.RemoverProducto(productoEncontrado, Cantidad);
                    sePudoDisminuir = true;
                    Console.WriteLine("El producto {0} con cantidad {1} se ha removido del carro del usuario {2}.", productoEncontrado.Nombre, Cantidad, usuarioEncontrado.Nombre);

                }
            }
            return sePudoDisminuir;
        }

        public bool VaciarCarro(int Id_Usuario)
        {

            bool sePudoVaciar = false;
            Usuario usuarioEncontrado;
            if (MercadoHelper.SonMenoresACero(new List<int> { Id_Usuario }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(Id_Usuario, usuarios))
            {
                Console.WriteLine("El usuario con id {0} no se pudo encontrar", Id_Usuario);
            }
            else
            {
                usuarios[Id_Usuario].MiCarro.Vaciar();
                Console.WriteLine("Se ha vaciado el carro correctamente.");
                sePudoVaciar = true;
            }
            return sePudoVaciar;

        }


        public bool Comprar(int ID_Usuario)
        {
            Double precioTotal = 0;
            bool sePudoComprar = false;
            Usuario usuarioEncontrado;
            if (MercadoHelper.SonMenoresACero(new List<int> { ID_Usuario }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(ID_Usuario, usuarios))
            {
                Console.WriteLine("El usuario con id {0} no se pudo encontrar", ID_Usuario);
            }
            else
            {
                usuarioEncontrado = usuarios[ID_Usuario];
                foreach(Producto producto in usuarioEncontrado.MiCarro.Productos.Keys)
                {
                    precioTotal += producto.Precio;
                }
               
                    precioTotal = MercadoHelper.CalcularPorcentaje(precioTotal,IVA);
                
                Dictionary<Producto, int> productosCompra = new Dictionary<Producto, int>(usuarioEncontrado.MiCarro.Productos); 
                Compra compra = new Compra(compras.Count + 1,usuarioEncontrado,productosCompra,precioTotal);
                compras.Add(compra);
                foreach(Producto producto in productosCompra.Keys){
                    productos[producto.Id].Cantidad -= producto.Cantidad;
                }
                usuarioEncontrado.MiCarro.Vaciar();
                sePudoComprar = true;
            }
            return sePudoComprar;
        }

        public bool ModificarCompra(int ID, Double Total)
        {

            bool seModifico = false;
            if (MercadoHelper.SonMenoresACero(new List<int> { ID }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            if (compras[ID] != null)
            {
                foreach (Producto producto in compras[ID].Productos.Keys)
                {
                    productos[producto.Id].Cantidad += producto.Cantidad;
                }
                compras[ID].Total = Total ;
                seModifico = true;
            } else
            {
                Console.WriteLine("La compra con Id {0} no existe.",ID);
            }

            return seModifico;

        }

        public bool EliminarCompra(int ID)
        {
            bool seElimino = false;
            if (MercadoHelper.SonMenoresACero(new List<int> { ID }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            if(compras[ID] != null)
            {
                foreach (Producto producto in compras[ID].Productos.Keys)
                {
                    productos[producto.Id].Cantidad += producto.Cantidad;
                }
                compras[ID] = null;
                seElimino = true;
            }
            else
            {
                Console.WriteLine("La compra con Id {0} no existe.", ID);
            }

            return seElimino;
        }
        public void MostrarTodosLosProductosPorPrecio()
        {
            var productoPorPrecio = productos.OrderBy(producto => producto.Precio);
            foreach (Producto p in productoPorPrecio)
            {
                Console.WriteLine(p);
            }

        }

        public void MostrarTodosLosProductosPorCategoria()
        {

            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine(categorias[i]);

                foreach (Producto producto in productos)
                {
                    if (producto.Cat.Equals(categorias[i]))
                    {
                        Console.WriteLine(producto.Nombre);
                    }
                }
            }

        }


        public List<Producto> MostrarProductoEnPantalla()
        {
            productos.Sort();

            return productos;
        }


        public int IniciarSesion(int cuil, string clave)
        {
            bool Inicia = false;
            int Id = -1;
            int i = 0;
            while (!Inicia && i < usuarios.Count)
            {
                Inicia = usuarios[i].Cuil == cuil && usuarios[i].Password == clave;
                if (Inicia)
                {
                    Id = usuarios[i].Id;
                }
                
                    i++;
            }
            return Id;


        }

        public bool esAdmin(int id) {

            bool esAdmin = false;

            int i = 0;
            while (!esAdmin && i < usuarios.Count)
            {
                
                if (esAdmin = usuarios[i].Id == id && usuarios[i].TipoUsuario == 1)
                {
                    esAdmin = true;
                }
                else if (esAdmin = usuarios[i].Id == id && usuarios[i].TipoUsuario != 1)
                { 
                   esAdmin = false;

                }
               
                    i++;
                
            }
            return esAdmin;

          
        }
            
    }
}
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
        int cantProductos;
        /* --- Variables auxiliares  ---*/

        private string[] contenidos = new string[10];

        Conexion conexion = new Conexion();   

        public Mercado()
        {
            productos = new List<Producto>();
            usuarios = new List<Usuario>();
            compras = new List<Compra>();
            categorias = new Categoria[maxCategorias];

            //FileManager.CreateFolder();

            

            ObtenerCategorias();
            ObtenerProductos();
            ObtenerUsuarios();
            ObtenerCompras();
        }

        private void ObtenerCategorias()
        {
            
            List<Categoria> auxCategoria = conexion.getCategorias();

            if (auxCategoria.Count != 0)
            {
                int i = 0;
                foreach (Categoria contenido in auxCategoria)
                {
                    categorias[i] = contenido;
                    i++;
                }
            }

        }
        private void ObtenerProductos()
        {
            productos = conexion.getProductos();


        }
        private void ObtenerUsuarios()
        {
            usuarios = conexion.getUsuarios();

        }       

        private void ObtenerCompras()
        { 
             compras = conexion.getCompras();
      
        }
        public bool AgregarProducto(string nombre, double precio, int Cantidad, int idCategoria)//Creamos producto y lo agregamos al array list de productos
        {
            cantProductos = conexion.cuentaRegistros("Producto") + 1;
            int indice = idCategoria - 1;
            if (categorias[indice] != null && categorias[indice].Id == idCategoria)
            {
                Producto producto = new Producto(cantProductos, nombre, precio, Cantidad, categorias[indice]);
                if (conexion.agregarProducto(producto))
                {
                    this.productos.Add(producto);
                    return true;
                }
                
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
                    conexion.modificaProducto(productos[i]);
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

                    if (conexion.eliminarRegistro("Producto", productos[i].Id))
                    {
                        productos.Remove(productos[i]);
                    }
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

        }

        public Producto BuscarProductoPorId(String Id)
        {
            Producto producto;
            bool sePudoParsear = Int32.TryParse(Id, out int idProducto);
            if (!sePudoParsear)
            {
                throw new Excepciones("No se pudo parsear el ID del producto buscado.");
            }
            else if (MercadoHelper.SonMenoresACero(new List<int> { idProducto }))
            {
                throw new Excepciones("El indice del producto que quiere buscar es menor a 0.");
            }
            else if (!MercadoHelper.ExisteElProducto(idProducto, productos))
            {
                throw new Excepciones("No existe el producto con ID " + idProducto);
            }
            else
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

        public List<Producto> MostrarProductoEnPantallaPorCategoria(int idCategoria)
        {
            if (idCategoria < 0 || idCategoria > categorias.Length)
            {
                throw new Excepciones("Id de categoria fuera del rango.");
            }
            return productos.FindAll(producto => producto.Cat.Id == idCategoria);
        }

        public List<Producto> MostrarProductosOrdenados(int orden)
        {
            List<Producto> productosOrdenados = new List<Producto>();
            if(orden < 0 || orden > 1)
            {
                throw new Excepciones("El numero de orden es incorrecto.");
            }
            if(orden == 0)
            {
                productosOrdenados = productos.OrderBy(producto => producto.Id).ToList();
            } else
            {
                productosOrdenados = productos.OrderByDescending(producto => producto.Id).ToList();
            }
            return productosOrdenados;
        }
        public bool AgregarUsuario(int cuil, String nombre, String apellido, String mail, String password, int tipoUsuario)
        {

            foreach (Usuario persona in usuarios)
            {
                if (persona.Cuil == cuil)
                {
                    return false;
                }

            }


            int id = usuarios.Count + 1;
            
            Carro micarro = new Carro(id);
            Usuario usuario = new Usuario(id, cuil, nombre, apellido, mail, password, micarro, tipoUsuario);
            if (conexion.agregarUsuario(usuario))
            {
                if (conexion.agregarCarroUsuario(micarro))
                {

                    usuarios.Add(usuario);
                }
                
            }
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
                    usuarios[id].Password = password;
                    usuarios[id].TipoUsuario = tipoUsuario;
                    conexion.modificaUsuario(usuarios[id]);
                    //FileManager.SaveListUsuarios(usuarios);
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
                    //eliminar usuario y carro del usuario
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

        public Usuario BuscarUsuarioPorId(String Id)
        {
            Usuario usuario;
            bool sePudoParsear = Int32.TryParse(Id, out int idUsuario);
            if (!sePudoParsear)
            {
                throw new Excepciones("No se puede parsear.");
            }
            else if (MercadoHelper.SonMenoresACero(new List<int> { idUsuario }))
            {
                throw new Excepciones("Este usuario no existe");
            }
            else if (!MercadoHelper.ExisteElUsuario(idUsuario, usuarios))
            {
                throw new Excepciones("No existe el producto con ID " + idUsuario);
            }
            else
            {
                usuario = usuarios[idUsuario - 1];
            }

            return usuario;
        }

        private bool BuscarCategoria(int ID)
        {
            foreach (Categoria categoria in categorias)
            {
                if (categoria == null)
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
                        conexion.modificarCategoria(categoria);
                        
                        break;
                    }
                }
            }
            cantCategorias = conexion.cuentaRegistros("Categoria");
            if (cantCategorias <= maxCategorias)

            {
                int id = cantCategorias + 1;
                if (BuscarCategoria(id))
                {
                    Categoria categoria = new Categoria(id, nombre);
                    if (conexion.agregarCategoria(categoria))
                    {

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
                conexion.modificarCategoria(categorias[ID]);
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
                    conexion.vaciarCategoria(categorias[i]);
                    //FileManager.SaveArrayCategorias(categorias);
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

        public Categoria BuscarCategoriaPorNombre(string Nombre)
        {
            Categoria categoriaEncontrada = null;
            foreach (Categoria categoria in categorias)
            {
                if (categoria.Nombre.Equals(Nombre))
                {
                    categoriaEncontrada = categoria;
                }
            }
            if(categoriaEncontrada == null)
            {
                throw new Excepciones("No se encontró la categoria.");
            }
            return categoriaEncontrada;
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
                throw new Excepciones("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(Id_Usuario, usuarios))
            {
                throw new Excepciones("El usuario con id " + Id_Usuario + " no se pudo encontrar");
            }
            else if (!MercadoHelper.ExisteElProducto(Id_Producto, productos))
            {
                throw new Excepciones("El producto con id " + Id_Producto + " no se pudo encontrar");
            }
            else
            {
                usuarioEncontrado = usuarios[Id_Usuario - 1];
                productoEncontrado = productos[Id_Producto];
                if (Cantidad > productoEncontrado.Cantidad)
                {
                    throw new Excepciones("La cantidad que se quiere agregar es mayor al stock disponible.");
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
                throw new Excepciones("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(Id_Usuario, usuarios))
            {
                throw new Excepciones("El usuario con id " + Id_Usuario + " no se pudo encontrar");
            }
            else if (!MercadoHelper.ExisteElProducto(Id_Producto, productos))
            {
                throw new Excepciones("El producto con id " + Id_Producto + " no se pudo encontrar");
            }
            else
            {
                usuarioEncontrado = usuarios[Id_Usuario - 1];
                productoEncontrado = productos[Id_Producto];
                if (!usuarioEncontrado.MiCarro.Productos.ContainsKey(productoEncontrado))
                {
                    throw new Excepciones("El producto "+ productoEncontrado + "no se encuentra en el carro de "+ usuarioEncontrado.Nombre + ".");
                }
                //else if (usuarioEncontrado.MiCarro.Productos[productoEncontrado] > Cantidad || Cantidad == 0)
                //{
                //    usuarioEncontrado.MiCarro.RemoverProducto(productoEncontrado, Cantidad);
                //    //("El producto "+ productoEncontrado.Nombre + " ha sido removido en su totalidad del carro del usuario "+ usuarioEncontrado.Nombre + ".");
                //}
                else
                {
                    usuarioEncontrado.MiCarro.RemoverProducto(productoEncontrado, Cantidad);
                    sePudoDisminuir = true;

                }
            }
            return sePudoDisminuir;
        }

        public bool VaciarCarro(int Id_Usuario)
        {

            bool sePudoVaciar = false;
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
                usuarios[Id_Usuario - 1].MiCarro.Vaciar();
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
                throw new Excepciones("Los parametros numericos deben ser mayor o igual a 0");
            }
            else if (!MercadoHelper.ExisteElUsuario(ID_Usuario, usuarios))
            {
                throw new Excepciones("El usuario con id " + ID_Usuario + " no se pudo encontrar");
            }
            else
            {
                usuarioEncontrado = usuarios[ID_Usuario - 1];
                foreach (Producto producto in usuarioEncontrado.MiCarro.Productos.Keys)
                {
                    precioTotal += producto.Precio;
                }
                precioTotal = MercadoHelper.CalcularPorcentaje(precioTotal, IVA);
                Dictionary<Producto, int> productosCompra = new Dictionary<Producto, int>(usuarioEncontrado.MiCarro.Productos);
                Compra compra = new Compra(compras.Count + 1, usuarioEncontrado, productosCompra, precioTotal);
                
                compras.Add(compra);
                conexion.agregarCompra(compra);

                foreach (Producto productoCompra in usuarioEncontrado.MiCarro.Productos.Keys)
                {
                    productos[productoCompra.Id].Cantidad -= usuarioEncontrado.MiCarro.Productos[productoCompra];

                }
                usuarioEncontrado.MiCarro.Vaciar();
                sePudoComprar = true;
            }
            return sePudoComprar;

            // guardar compra en Productos_compra
        }

        //guarda que no lo estamos usando!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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
                compras[ID].Total = Total;
                seModifico = true;
            }
            else
            {
                Console.WriteLine("La compra con Id {0} no existe.", ID);
            }

            return seModifico;
            //modificar en productos compra
        }

        public bool EliminarCompra(int ID)
        {
            bool seElimino = false;
            if (MercadoHelper.SonMenoresACero(new List<int> { ID }))
            {
                Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
            }
            if (compras[ID-1] != null)
            {
                foreach (Producto producto in compras[ID-1].Productos.Keys)
                {
                    productos[producto.Id].Cantidad += producto.Cantidad;
                }
                compras[ID-1] = null;
                seElimino = true;
                //eliminar compra en conexion por id compra
                FileManager.SaveListCompras(compras);
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
            return productos.OrderBy(propiedad => propiedad.Id).ToList();
        }
        
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
                string miString ="";
                foreach(Producto prod in productos.Keys)
                {
                    miString += $" {prod.Nombre} - {productos[prod]}\n ";
                }
                return miString;
            }
        }
        public List<CompraRealizada> mostrarComprasRealizadas()
        {
            List<CompraRealizada> comprado = new List<CompraRealizada>();
            
            foreach (Compra compra in compras)
            {
                if(compra != null)
                {

                    comprado.Add(new CompraRealizada(compra.Id, compra.Comprador, compra.Total, compra.Productos));
                }
            }
            
            

            return comprado;
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

        public bool esAdmin(int id)
        {

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
using Microsoft.EntityFrameworkCore;
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

        //private DbSet<Categoria> misCategorias;
        MyContext db;

        Conexion conexion = new Conexion();

        public Mercado()
        {
            productos = new List<Producto>();
            usuarios = new List<Usuario>();
            compras = new List<Compra>();
            categorias = new Categoria[maxCategorias];

            db = new MyContext();
            db.categorias.Load();
            db.usuarios.Load();
            db.productos.Load();
            db.compras.Load();
            db.carro.Load();



            ObtenerCategorias();
            ObtenerProductos();
            ObtenerUsuarios();
            ObtenerCompras();
            ObtenerCarros();
        }

        private void ObtenerCategorias()
        {

            var list = db.categorias;

            if (list.Count() != 0)
            {
                int i = 0;
                foreach (var u in list)
                {
                    Categoria cat = new Categoria(u.CatId, u.Nombre);
                    categorias[i] = cat;
                    i++;
                }
            }

        }
        public void ObtenerProductos()
        {
            //productos = conexion.getProductos();
            var list = db.productos;

            if (list.Count() != 0)
            {
                foreach (var p in list)
                {
                    Categoria aux = null;
                    foreach (Categoria cat in categorias)
                    {
                        if (cat.CatId == p.CatId)
                        {
                            aux = cat;
                        }
                    }
                    productos.Add(new Producto(p.ProductoId, p.Nombre, p.Precio, p.Cantidad, aux));
                }
            }

        }



        public List<Producto> todosProductos()
        {
            return db.productos.OrderBy(propiedad => propiedad.ProductoId).ToList(); ;
        }



        private void ObtenerUsuarios()
        {
            //usuarios = conexion.getUsuarios();
            var list = db.usuarios;
            if (list.Count() != 0)
            {
                foreach (var u in list)
                {
                    Carro micarro = new Carro(u.UsuarioId);

                    usuarios.Add(new Usuario(u.UsuarioId, u.Cuil, u.Nombre, u.Apellido, u.Mail, u.Password, micarro, u.TipoUsuario));
                }

            }

        }

        private void ObtenerCompras()
        {


            var list = db.compras;
            if (list.Count() != 0)
            {
                foreach (var u in list)
                {
                    Compra compra = new Compra(u.CompraId, u.Usuario, u.Total);

                    compras.Add(new Compra(u.CompraId, u.Usuario, u.Total));
                }

            }

        }





        public bool AgregarProducto(string nombre, double precio, int Cantidad, int idCategoria)
        {
            try
            {
                Categoria cat = db.categorias.Where(u => u.CatId == idCategoria).FirstOrDefault();

                cantProductos = db.productos.Count() + 1;

                if (cat != null)
                {
                    if (cat.Productos == null)
                        cat.Productos = new List<Producto>();

                    Producto prod = new Producto { ProductoId = cantProductos, Nombre = nombre, Precio = precio, Cantidad = Cantidad, Cat = cat };
                    cat.Productos.Add(prod);
                    db.productos.Add(prod);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool ModificarProducto(int ID, string Nombre, double Precio, int Cantidad, int ID_Categoria)
        {
            bool salida = false;
            foreach (Producto u in db.productos)
                if (u.ProductoId == ID)
                {
                    u.Nombre = Nombre;
                    u.Precio = Precio;
                    u.Cantidad = Cantidad;
                    u.CatId = ID_Categoria;
                    db.productos.Update(u);
                    salida = true;
                }
            if (salida)
                db.SaveChanges();
            return salida;
        }

        public bool EliminarProducto(int id)
        {
            try
            {
                bool salida = false;
                foreach (Producto u in db.productos)
                    if (u.ProductoId == id)
                    {
                        db.productos.Remove(u);
                        salida = true;
                    }
                if (salida)
                    db.SaveChanges();
                return salida;
            }
            catch (Exception)
            {
                return false;
            }
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
        public Producto BuscarProductoPorId(int Id)
        {

            Producto producto = db.productos.Where(u => u.ProductoId == Id).FirstOrDefault();

            return producto;
        }
        //public Producto BuscarProductoPorId(String Id)
        //{
        //    Producto producto;
        //    bool sePudoParsear = Int32.TryParse(Id, out int idProducto);
        //    if (!sePudoParsear)
        //    {
        //        throw new Excepciones("No se pudo parsear el ID del producto buscado.");
        //    }
        //    else if (MercadoHelper.SonMenoresACero(new List<int> { idProducto }))
        //    {
        //        throw new Excepciones("El indice del producto que quiere buscar es menor a 0.");
        //    }
        //    else if (!MercadoHelper.ExisteElProducto(idProducto, productos))
        //    {
        //        throw new Excepciones("No existe el producto con ID " + idProducto);
        //    }
        //    else
        //    {
        //        producto = productos[idProducto];
        //    }

        //    return producto;
        //}


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
                if (producto.Cat.CatId == ID_Categoria)
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
            return productos.FindAll(producto => producto.Cat.CatId == idCategoria);
        }

        public List<Producto> MostrarProductosOrdenados(int orden)
        {
            List<Producto> productosOrdenados = new List<Producto>();
            if (orden < 0 || orden > 1)
            {
                throw new Excepciones("El numero de orden es incorrecto.");
            }
            if (orden == 0)
            {
                productosOrdenados = productos.OrderBy(producto => producto.ProductoId).ToList();
            }
            else
            {
                productosOrdenados = productos.OrderByDescending(producto => producto.ProductoId).ToList();
            }
            return productosOrdenados;
        }


        public bool AgregarUsuario(int cuil, String nombre, String apellido, String mail, String password, int tipoUsuario)
        {
            try
            {

                foreach (Usuario persona in usuarios)
                {
                    if (persona.Cuil == cuil)
                    {
                        return false;
                    }

                }

                int cantCarros = db.usuarios.Count() + 1;
                Carro carro = new Carro(cantCarros, cantCarros);
                Usuario nuevo = new Usuario { UsuarioId = cantCarros, Cuil = cuil, Nombre = nombre, Apellido = apellido, Mail = mail, Password = password, Carro = carro, TipoUsuario = tipoUsuario };

                carro.Usuario = nuevo;

                db.usuarios.Add(nuevo);
                db.carro.Add(carro);


                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool ModificarUsuario(int ID, String nombre, String apellido, String mail, String password, int tipoUsuario)
        {
            bool salida = false;
            foreach (Usuario u in db.usuarios)
                if (u.UsuarioId == ID)
                {
                    u.Nombre = nombre;
                    u.Apellido = apellido;
                    u.Mail = mail;
                    u.Password = password;
                    u.TipoUsuario = tipoUsuario;
                    db.usuarios.Update(u);
                    salida = true;
                }
            if (salida)
                db.SaveChanges();
            return salida;
        }


        public bool EliminarUsuario(int id)
        {
            try
            {
                bool salida = false;
                foreach (Usuario u in db.usuarios)
                    if (u.UsuarioId == id)
                    {
                        db.usuarios.Remove(u);
                        salida = true;
                    }
                if (salida)
                    db.SaveChanges();
                return salida;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<Usuario> MostrarUsuarioEnPantalla()
        {

            List<Usuario> salida = new List<Usuario>();
            foreach (Usuario u in db.usuarios)
                salida.Add(u);
            return salida;
        }
        public List<Usuario> MostrarUsuarios()
        {
            return db.usuarios.OrderBy(propiedad => propiedad.UsuarioId).ToList();

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
        public bool AgregarCategoria(string nombre)
        {

            foreach (Categoria categoria in categorias)
            {
                if (categoria != null)
                {
                    if (categoria.Nombre.Equals(" "))
                    {
                        categoria.Nombre = nombre;


                        var cat = db.categorias.Where(c => c.Nombre == " ").FirstOrDefault();
                        cat.Nombre = nombre;
                        var respuesta = db.SaveChanges();


                        break;
                    }
                }
            }
            cantCategorias = db.categorias.Count();
            if (cantCategorias <= maxCategorias)

            {
                int id = cantCategorias + 1;
                if (BuscarCategoria(id))
                {
                    Categoria categoria = new Categoria(id, nombre);
                    db.categorias.Add(categoria);
                    var seGuardo = db.SaveChanges();

                    if (seGuardo > 0)
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

                return true;

            }

            return false;
        }

        public bool ModificarCategoria(int ID, string Nombre)
        {

            if (categorias[ID - 1] != null)
            {
                categorias[ID - 1].Nombre = Nombre;

                var cat = db.categorias.Where(c => c.CatId == ID).FirstOrDefault();
                cat.Nombre = Nombre;
                db.SaveChanges();

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
                    encontre = categorias[i].CatId == ID;

                }
                if (encontre)
                {

                    categorias[i].Nombre = " ";

                    var cat = db.categorias.Where(c => c.CatId == ID).FirstOrDefault();
                    cat.Nombre = " ";
                    db.SaveChanges();

                }

                i++;
            }
            return encontre;
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
            if (categoriaEncontrada == null)
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
                productoEncontrado = productos[Id_Producto - 1];
                if (Cantidad > productoEncontrado.Cantidad)
                {
                    throw new Excepciones("La cantidad que se quiere agregar es mayor al stock disponible.");
                }
                else
                {
                    int carro_productos_Id = db.Carro_productos.Count() + 1;
                    int id_carro = Id_Usuario - 1;
                    Carro carro = new Carro(id_carro, Id_Usuario - 1);
                    Producto producto = BuscarProductoPorId(Id_Producto);

                    Carro_productos carroProductos = new Carro_productos(id_carro, Id_Producto, Cantidad, producto);
                    db.Carro_productos.Add(carroProductos);

                    db.SaveChanges();

                    usuarioEncontrado.Carro.AgregarProducto(producto, Cantidad);

                    sePudoAgregar = true;

                    Console.WriteLine("El producto {0} con cantidad {1} se ha añadido al carro del usuario {2}.", productoEncontrado.Nombre, Cantidad, usuarioEncontrado.Nombre);

                }
            }
            return sePudoAgregar;
        }

        public void ObtenerCarros()
        {
            var carroProductos = db.Carro_productos;
            if (carroProductos.Count() != 0)
            //Armar un mapa <Usuario,List<Producto>> donde va a guardar 
            {
                //Dictionary<Usuario, Dictionary<Producto,int>> productosPorUsuario = new Dictionary<Usuario, Dictionary<Producto, int>>();
                foreach (var carroProducto in carroProductos)
                {

                    //Buscar el usuario a partir del id de carro (es igual)
                    //Buscar todos los productos que tenga el carro y agregarlos al carro (Usuario.Carro.AgregarProducto)



                    Usuario usuarioEncontrado = usuarios.Find(usuario => usuario.UsuarioId == carroProducto.Id_Carro); ;
                    if (usuarioEncontrado != null)
                    {
                        Producto producto = productos.Find(prod => prod.ProductoId == carroProducto.Id_Producto);
                        if (producto != null)
                        {
                            int cantidadProductoCarro = carroProducto.Cantidad;
                            if (usuarioEncontrado.Carro == null)
                            {
                                usuarioEncontrado.Carro = new Carro(usuarioEncontrado.UsuarioId, producto, cantidadProductoCarro);

                            }

                            usuarioEncontrado.Carro.AgregarProducto(producto, cantidadProductoCarro);
                        }
                    }

                }
            }
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
                productoEncontrado = productos[Id_Producto - 1];
                if (!usuarioEncontrado.Carro.Productos.ContainsKey(productoEncontrado))
                {
                    throw new Excepciones("El producto " + productoEncontrado + "no se encuentra en el carro de " + usuarioEncontrado.Nombre + ".");
                }
                //else if (usuarioEncontrado.MiCarro.Productos[productoEncontrado] > Cantidad || Cantidad == 0)
                //{
                //    usuarioEncontrado.MiCarro.RemoverProducto(productoEncontrado, Cantidad);
                //    //("El producto "+ productoEncontrado.Nombre + " ha sido removido en su totalidad del carro del usuario "+ usuarioEncontrado.Nombre + ".");
                //}
                else
                {
                    usuarioEncontrado.Carro.RemoverProducto(productoEncontrado, Cantidad);
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
                usuarios[Id_Usuario - 1].Carro.Vaciar();
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

                //ObtenerUsuarios();
                //ObtenerCarros();

                Usuario usuario = usuarios.Find(usuario => usuario.UsuarioId == ID_Usuario - 1);

                Carro carrosProductos = usuario.Carro;

                foreach (var producto in carrosProductos.ProductosCompra)
                {
                    
                    precioTotal += producto.Precio * producto.Cantidad;
                }


                precioTotal = MercadoHelper.CalcularPorcentaje(precioTotal, IVA);

                Compra compra = new Compra(usuario.UsuarioId, precioTotal);

                compra.CompraProducto = new List<Producto>();

                foreach (Producto prod in usuario.Carro.ProductosCompra)
                    compra.CompraProducto.Add(prod);


                db.compras.Add(compra);
                db.SaveChanges();

               
                   foreach(Productos_compra pc in compra.Productos_compra)
                        if (pc.Id_compra == compra.CompraId)
                           
                           foreach (Carro_productos p in usuario.Carro.Carro_productos)
                                p.Cantidad -= pc.Cantidad_producto;


                usuario.Carro.Vaciar();
                db.SaveChanges();

                //if (comprado == 1)
                //{





                //    db.compras.Add(compra);
                //    Compra ultimaCompra = db.compras.OrderByDescending(c => c.CompraId).FirstOrDefault();
                //    int idCompra = ultimaCompra.CompraId;

                //    foreach (Producto productoCompra in usuario.Carro.Productos.Keys)
                //    {
                //        int cantidad = usuario.Carro.Productos[productoCompra];
                //        bool seAgrego = agregarProductoCompra(productoCompra, cantidad, idCompra);
                //        bool seActualizoStock = ActualizarStockProducto(productoCompra.ProductoId, cantidad);
                //        bool seActualizoCarro = ActualizarCarro(ID_Usuario);
                //        if(seActualizoStock && seActualizoCarro && seAgrego)
                //        {
                //            usuario.Carro.Vaciar();
                //            sePudoComprar = true;
                //        } else
                //        {
                //            sePudoComprar = false;
                //            break;
                //        }
                //    }

                //}
                //sePudoComprar = true;


            }
            return sePudoComprar;

            // guardar compra en Productos_compra
        }



        public bool agregarProductoCompra(Producto producto, int cantidad, int idCompra)
        {
            Productos_compra productoCompra = new Productos_compra(idCompra, producto.ProductoId, cantidad);
            db.Productos_compra.Add(productoCompra);
            return db.SaveChanges() > 0;

        }



        public bool ActualizarStockProducto(int idProducto, int cantidad)
        {

            var productoEncontrado = db.productos.FirstOrDefault(producto => producto.ProductoId == idProducto);

            if (productoEncontrado != null)
            {
                productoEncontrado.Cantidad -= cantidad;
                db.SaveChanges();
                return true;
            }
            return false;
        }


        public bool ActualizarCarro(int idCarro)
        {

            var carrosProductos = db.Carro_productos.Where(carroProd => carroProd.Id_Carro == idCarro);
            if (carrosProductos != null)
            {
                foreach (var carroProducto in carrosProductos)
                {
                    db.Carro_productos.Remove(carroProducto);
                    db.SaveChanges();
                }
                return true;
            }
            return false;



        }





        //guarda que no lo estamos usando!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //public bool ModificarCompra(int ID, Double Total)
        //{

        //    bool seModifico = false;
        //    if (MercadoHelper.SonMenoresACero(new List<int> { ID }))
        //    {
        //        Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
        //    }
        //    if (compras[ID] != null)
        //    {
        //        foreach (Producto producto in compras[ID].Productos.Keys)
        //        {
        //            productos[producto.ProductoId].Cantidad += producto.Cantidad;
        //        }
        //        compras[ID].Total = Total;
        //        seModifico = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("La compra con Id {0} no existe.", ID);
        //    }

        //    return seModifico;
        //    //modificar en productos compra
        //}

        //public bool EliminarCompra(int ID)
        //{
        //    bool seElimino = false;
        //    if (MercadoHelper.SonMenoresACero(new List<int> { ID }))
        //    {
        //        Console.WriteLine("Los parametros numericos deben ser mayor o igual a 0");
        //    }
        //    if (compras[ID-1] != null)
        //    {
        //        foreach (Producto producto in compras[ID-1]..Keys)
        //        {
        //            productos[producto.ProductoId].Cantidad += producto.Cantidad;
        //        }
        //        compras[ID-1] = null;
        //        seElimino = true;
        //        //eliminar compra en conexion por id compra
        //        //FileManager.SaveListCompras(compras);
        //    }
        //    else
        //    {
        //        Console.WriteLine("La compra con Id {0} no existe.", ID);
        //    }

        //    return seElimino;
        //}
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

            List<Producto> salida = new List<Producto>();
            foreach (Producto p in db.productos)
                salida.Add(p);
            return salida;
        }


        public List<Compra> mostrarComprasRealizadas()
        {
            List<Compra> salida = new List<Compra>();
            foreach (Compra c in db.compras)
                salida.Add(c);
            return salida;
        }
        public List<Carro_productos> mostrarCarroPantalla(int id_usuario)
        {
            List<Carro_productos> carro = new List<Carro_productos>();
            Carro_productos micarro = new Carro_productos();
            var aux = db.Carro_productos.Where(c => c.Id_Carro == id_usuario);
            //agregar el if null y un for para recorrer mas de un item
            if (aux != null)
            {
                foreach (var u in aux)
                {
                    micarro.Id_Carro = u.Id_Carro;
                    micarro.Id_Producto = u.Id_Producto;
                    micarro.Cantidad = u.Cantidad;
                    micarro.Producto = BuscarProductoPorId(u.Id_Producto);

                }
            }
            return db.Carro_productos.OrderBy(propiedad => propiedad.Id_Producto).ToList();
            //return carro;
        }

        public bool modificarMonto(int id, double monto)
        {
            bool salida = false;
            foreach (Compra u in db.compras)
                if (u.CompraId == id)
                {
                    u.Total = monto;
                    db.compras.Update(u);
                    salida = true;
                }
            if (salida)
                db.SaveChanges();
            return salida;
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
                    Id = usuarios[i].UsuarioId;
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

                if (esAdmin = usuarios[i].UsuarioId == id && usuarios[i].TipoUsuario == 1)
                {
                    esAdmin = true;
                }
                else if (esAdmin = usuarios[i].UsuarioId == id && usuarios[i].TipoUsuario != 1)
                {
                    esAdmin = false;

                }

                i++;

            }
            return esAdmin;


        }

    }
}
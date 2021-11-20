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
      
        private string[] contenidos = new string[10];

        MyContext db;
              

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
        }

        public List<Producto> todosProductos()
        {
            return db.productos.OrderBy(propiedad => propiedad.ProductoId).ToList(); ;
        }

        public List<Categoria> todasCategorias()
        {
            return db.categorias.OrderBy(propiedad => propiedad.CatId).ToList(); ;
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


        public void BuscarProductosPorCategoria(int ID_Categoria)
        {
            foreach (Producto producto in db.productos)
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
            List<Producto> salida = new List<Producto>();
            foreach (Producto p in db.productos.Where(p => p.Cat.CatId == idCategoria))
                salida.Add(p);
            return salida;
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
                productosOrdenados = db.productos.OrderBy(producto => producto.ProductoId).ToList();
            }
            else
            {
                productosOrdenados = db.productos.OrderByDescending(producto => producto.ProductoId).ToList();
            }
            return productosOrdenados;
        }


        public bool AgregarUsuario(int cuil, String nombre, String apellido, String mail, String password, int tipoUsuario)
        {
            try
            {
                Usuario usuario = db.usuarios.Where(u => u.Cuil == cuil).FirstOrDefault();

                if (usuario != null)
                {
                    return false;
                }

                int cantCarros = db.usuarios.Count() + 1;
                Carro carro = new Carro { CarroId = cantCarros, UsuarioId = cantCarros };
                Usuario nuevo = new Usuario { UsuarioId = cantCarros, Cuil = cuil, Nombre = nombre, Apellido = apellido, Mail = mail, Password = password, Carro = carro, TipoUsuario = tipoUsuario };

               
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
            
            bool sePudoParsear = Int32.TryParse(Id, out int idUsuario);
            Usuario usuario = db.usuarios.Where(u => u.UsuarioId == idUsuario).FirstOrDefault();
            if (!sePudoParsear)
            {
                throw new Excepciones("No se puede parsear.");
            } else if (usuario == null) {
                throw new Excepciones("Este usuario no existe");
            }else
            {
                usuario = db.usuarios.Where(u => u.UsuarioId == idUsuario).FirstOrDefault(); ;
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
            Categoria categoria = db.categorias.Where(cat => cat.Nombre == Nombre).FirstOrDefault();
            return categoria;
        }

        public Categoria[] MostrarCategorias()
        {
            return categorias;
        }

        public bool AgregarAlCarro(int Id_Producto, int Cantidad, int Id_Usuario)
        {
            bool sePudoAgregar = false;
            Usuario usuarioEncontrado = db.usuarios.Where(u => u.UsuarioId == Id_Usuario).FirstOrDefault();
            Producto productoEncontrado = db.productos.Where(p => p.ProductoId == Id_Producto).FirstOrDefault();
            if (MercadoHelper.SonMenoresACero(new List<int> { Id_Producto, Cantidad, Id_Usuario }))
            {
                throw new Excepciones("Los parametros numericos deben ser mayor o igual a 0");
            }
           
            else
            {
                
                if (Cantidad > productoEncontrado.Cantidad)
                {
                    throw new Excepciones("La cantidad que se quiere agregar es mayor al stock disponible.");
                }
                else
                {
                    int carro_productos_Id = db.Carro_productos.Count() + 1;
                    int id_carro = usuarioEncontrado.MiCarro;
                    
                
                    Producto producto = BuscarProductoPorId(Id_Producto);

                    Carro_productos carroProductos = new Carro_productos(id_carro, Id_Producto, Cantidad, producto);
                    db.Carro_productos.Add(carroProductos);

                    db.SaveChanges();

                    sePudoAgregar = true;
                }
            }
            return sePudoAgregar;
        }

        public bool QuitarDelCarro(int Id_Producto, int Id_Usuario)
        {
            bool seQuito = false;

            Usuario usuario = db.usuarios.Where(u => u.UsuarioId == Id_Usuario).FirstOrDefault();
            Producto productoEncontrado = db.productos.Where(p => p.ProductoId == Id_Producto).FirstOrDefault();

            Carro carrito = usuario.Carro;
          
            Carro_productos prodABorrar = db.Carro_productos.Where(carro => carro.Id_Carro == Id_Usuario && carro.Id_Producto == Id_Producto).FirstOrDefault();

            db.Carro_productos.Remove(prodABorrar);
                        
            db.SaveChanges();
                       
            return seQuito;
        }

        public void Vaciar(int Id_Usuario)
        {
           var carroABorrar = db.Carro_productos.Where(carro => carro.Id_Carro == Id_Usuario);
           db.Carro_productos.RemoveRange(carroABorrar);
           db.SaveChanges();
        }


        public bool Comprar(int ID_Usuario)
        {
            Double precioTotal = 0;
            bool sePudoComprar = false;
            Usuario usuario = db.usuarios.Where(usuario => usuario.UsuarioId == ID_Usuario).FirstOrDefault();
                       
            Carro_productos carrosProductos = db.Carro_productos.Where(carro => carro.Id_Carro == ID_Usuario).FirstOrDefault();

            foreach (Carro_productos producto in mostrarCarroPantalla(ID_Usuario))
                       precioTotal += producto.Cantidad * producto.Producto.Precio;

            precioTotal = MercadoHelper.CalcularPorcentaje(precioTotal, IVA);

            Compra compra = new Compra(usuario.UsuarioId, precioTotal);

            db.compras.Add(compra);
            db.SaveChanges();

           var datosCarrito = db.Carro_productos.Where(us => us.Id_Carro == ID_Usuario);

            foreach(var p in datosCarrito.ToList())
            {
             Productos_compra comprado = new Productos_compra(compra.CompraId, p.Id_Producto, p.Cantidad);
                db.Productos_compra.Add(comprado);
                ActualizarStockProducto(p.Id_Producto, p.Cantidad);
                db.SaveChanges();

            }
                                   
            sePudoComprar = true;
            return sePudoComprar;
                       
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


        public Producto BuscarProductoPorId(int Id)
        {
            Producto producto = db.productos.Where(u => u.ProductoId == Id).FirstOrDefault();
            return producto;
        }

        public Producto BuscarProductoPorNombre(string busca)
        {
            Producto producto = db.productos.Where(u => u.Nombre.Contains(busca)).FirstOrDefault();
            return producto;
        }

        public List<Producto> BusquedaProductos(string busca)
        {
            List<Producto> producto = db.productos.Where(u => u.Nombre.Contains(busca)).ToList();
            return producto;
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

            foreach (Carro_productos c in db.Carro_productos.Where(c => c.Id_Carro == id_usuario))
                carro.Add(c);

            return carro;
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
            int Id = -1;

            Usuario usuario = db.usuarios.Where(u => u.Cuil == cuil).FirstOrDefault();

            if (usuario != null)
            {
                if (usuario.Password == clave)
                {
                    Id = usuario.UsuarioId;
                }
                return Id;
            }

            return Id;
        }

        public bool esAdmin(int id)
        {
            bool esAdmin = false;

            Usuario usuario = db.usuarios.Where(u => u.UsuarioId == id).FirstOrDefault();

            if(usuario.TipoUsuario == 1)
                 esAdmin = true;
            
            return esAdmin;
        }

    }
}
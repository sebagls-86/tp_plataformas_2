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
        public List<Categoria> categorias { get; set; }

        public readonly double IVA = 21;
        public List<Compra> compras { get; set; }

        MyContext db;

        public Mercado()
        {
            productos = new List<Producto>();
            usuarios = new List<Usuario>();
            compras = new List<Compra>();
            categorias = new List<Categoria>();

            db = new MyContext();
            db.categorias.Load();
            db.usuarios.Load();
            db.productos.Include(u => u.CarroProducto).Include(u => u.CompraProducto).Load();
            db.compras.Include(u => u.CompraProducto).Load();
            db.carro.Include(u => u.ProductosCompra).Load();

        }

        public List<Producto> todosProductos()
        {
            return db.productos.OrderBy(propiedad => propiedad.ProductoId).ToList();
        }

        public List<Categoria> todasCategorias()
        {
            return db.categorias.OrderBy(propiedad => propiedad.CatId).ToList();
        }

        public bool AgregarProducto(string nombre, double precio, int Cantidad, int idCategoria)
        {
            try
            {
                Categoria cat = db.categorias.Where(u => u.CatId == idCategoria).FirstOrDefault();

                if (cat != null)
                {
                    Producto prod = new Producto { Nombre = nombre, Precio = precio, Cantidad = Cantidad, Cat = cat };
                   
                    db.productos.Add(prod);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool ModificarProducto(int ID, string Nombre, double Precio, int Cantidad, int ID_Categoria)
        {
            bool salida = false;
            Producto prod = db.productos.Where(p => p.ProductoId == ID).FirstOrDefault();

            try
            {
                prod.Nombre = Nombre;
                prod.Precio = Precio;
                prod.Cantidad = Cantidad;
                prod.CatId = ID_Categoria;
                db.productos.Update(prod);
                db.SaveChanges();
                salida = true;
            }
            catch (Exception)
            {
                salida = false;
            }

            return salida;
        }

        public bool EliminarProducto(int id)
        {
            bool salida = false;
            Producto prod = db.productos.Where(p => p.ProductoId == id).FirstOrDefault();

            try
            {
                db.productos.Remove(prod);
                db.SaveChanges();
                salida = true;
            }
            catch (Exception)
            {
                return false;
            }

            return salida;
        }


        public List<Producto> MostrarProductoEnPantallaPorCategoria(int idCategoria)
        {
            return db.productos.Where(p => p.Cat.CatId == idCategoria).ToList();
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

            bool agregado = false;
            try
            {
                Usuario usuario = db.usuarios.Where(u => u.Cuil == cuil).FirstOrDefault();

                if (usuario != null)
                {
                    agregado = false;
                }

                Carro carro = new Carro();
                Usuario nuevo = new Usuario { Cuil = cuil, Nombre = nombre, Apellido = apellido, Mail = mail, Password = password, Carro = carro, TipoUsuario = tipoUsuario };

                db.usuarios.Add(nuevo);
                db.carro.Add(carro);
                db.SaveChanges();

                Carro lastCarro = db.carro.OrderBy(c => c.CarroId).Last();
                int MiCarro = lastCarro.CarroId;
                nuevo.MiCarro = MiCarro;
                db.usuarios.Update(nuevo);
                db.SaveChanges();

                agregado = true;

            }
            catch (Exception)
            {
                return false;
            }

            return agregado;
        }

        public bool ModificarUsuario(int ID, String nombre, String apellido, String mail, String password, int tipoUsuario)
        {
            bool salida = false;
            Usuario usu = db.usuarios.Where(p => p.UsuarioId == ID).FirstOrDefault();
            try
            {
                usu.Nombre = nombre;
                usu.Apellido = apellido;
                usu.Mail = mail;
                usu.Password = password;
                usu.TipoUsuario = tipoUsuario;
                db.usuarios.Update(usu);
                db.SaveChanges();
                salida = true;

            }
            catch (Exception)
            {
                salida = false;
            }

            return salida;
        }


        public bool EliminarUsuario(int id)
        {
            bool salida = false;
            Usuario usu = db.usuarios.Where(p => p.UsuarioId == id).FirstOrDefault();

            try
            {
                db.usuarios.Remove(usu);
                db.SaveChanges();
                salida = true;
            }
            catch (Exception)
            {
                return false;
            }

            return salida;
        }

        public List<Usuario> MostrarUsuarioEnPantalla()
        {
            return db.usuarios.ToList();
        }
        public List<Usuario> MostrarUsuarios()
        {
            return db.usuarios.OrderBy(propiedad => propiedad.UsuarioId).ToList();
        }

        public Usuario BuscarUsuarioPorId(int Id)
        {
            Usuario usuario = db.usuarios.Where(u => u.UsuarioId == Id).FirstOrDefault();
            usuario = db.usuarios.Where(u => u.UsuarioId == Id).FirstOrDefault(); ;
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
            bool salida = false;
            try
            {
                Categoria cat = db.categorias.Where(u => u.Nombre.ToLower() == nombre.ToLower()).FirstOrDefault();

                if (cat == null)
                {
                    Categoria nuevaCat = new Categoria(nombre);
                    db.categorias.Add(nuevaCat);
                    db.SaveChanges();
                    salida = true;
                }
                else
                {
                    salida = false;
                }
            }
            catch (Exception)
            {
                salida = false;
            }

            return salida;
        }


        public bool ModificarCategoria(int ID, string Nombre)
        {

            bool salida = false;
            Categoria cat = db.categorias.Where(p => p.CatId == ID).FirstOrDefault();

            try
            {
                cat.Nombre = Nombre;
                db.categorias.Update(cat);
                db.SaveChanges();
                salida = true;

            }
            catch (Exception)
            {
                salida = false;
            }

            return salida;
        }
        public bool EliminarCategoria(int id)
        {
            bool salida = false;
            try
            {

                Categoria cat = db.categorias.Where(u => u.CatId == id).FirstOrDefault();
                db.categorias.Remove(cat);
                db.SaveChanges();
                salida = true;
            }

            catch (Exception)
            {
                return false;
            }
            return salida;
        }

        public Categoria BuscarCategoriaPorNombre(string Nombre)
        {
            return db.categorias.Where(cat => cat.Nombre == Nombre).FirstOrDefault(); ;
        }

        public List<Categoria> MostrarCategorias()
        {
            return db.categorias.ToList();
        }

        public bool AgregarAlCarro(int Id_Producto, int Cantidad, int Id_Usuario)
        {
            bool sePudoAgregar = false;
            Usuario usuarioEncontrado = db.usuarios.Where(u => u.UsuarioId == Id_Usuario).FirstOrDefault();
            Producto productoEncontrado = db.productos.Where(p => p.ProductoId == Id_Producto).FirstOrDefault();

            if (MercadoHelper.SonMenoresACero(new List<int> { Id_Producto, Cantidad, Id_Usuario }))
            {
                sePudoAgregar = false;
                throw new Excepciones("Los parametros numericos deben ser mayor a 0");

            }
            else if (Cantidad > productoEncontrado.Cantidad)
            {
                sePudoAgregar = false;
                throw new Excepciones("La cantidad que se quiere agregar es mayor al stock disponible.");
            }
            else
            {
                Carro cart = usuarioEncontrado.Carro;
                cart.ProductosCompra.Add(productoEncontrado);
                db.carro.Update(cart);
                db.SaveChanges();
                cart.Carro_productos.Last<Carro_productos>().Cantidad = Cantidad;
                db.carro.Update(cart);
                db.SaveChanges();
                sePudoAgregar = true;
            }

            return sePudoAgregar;
        }

        public bool QuitarDelCarro(int Id_Producto, int Id_Usuario)
        {
            bool seQuito = false;
            try
            {
                Usuario usuario = db.usuarios.Where(u => u.UsuarioId == Id_Usuario).FirstOrDefault();
                Producto productoEncontrado = db.productos.Where(p => p.ProductoId == Id_Producto).FirstOrDefault();
                Carro carrito = usuario.Carro;
                Carro_productos prodABorrar = db.Carro_productos.Where(carro => carro.Id_Carro == Id_Usuario && carro.Id_Producto == Id_Producto).FirstOrDefault();
                db.Carro_productos.Remove(prodABorrar);
                db.SaveChanges();
                seQuito = true;
            }
            catch (Exception)
            {
                seQuito = false;
            }
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
            Carro carro = usuario.Carro;

            try
            {

                foreach (Producto prod in carro.ProductosCompra)
                {

                    foreach (Carro_productos cp in carro.Carro_productos)
                        if (cp.Id_Carro == carro.CarroId && cp.Id_Producto == prod.ProductoId)
                            precioTotal += cp.Cantidad * prod.Precio;
                }

                precioTotal = MercadoHelper.CalcularPorcentaje(precioTotal, IVA);
                Compra compra = new Compra(usuario.UsuarioId, precioTotal);
                db.compras.Add(compra);
                db.SaveChanges();

                sePudoComprar = true;

                if (sePudoComprar)
                {
                    try
                    {
                        foreach (Producto prod in carro.ProductosCompra)
                        {

                            compra.CompraProducto.Add(prod);

                            db.compras.Update(compra);
                            db.SaveChanges();
                            foreach (Carro_productos cp in carro.Carro_productos)
                            {
                                if (cp.Id_Carro == carro.CarroId && cp.Id_Producto == prod.ProductoId)
                                    compra.Productos_compra.Last<Productos_compra>().Cantidad_producto = cp.Cantidad;
                                ActualizarStockProducto(cp.Id_Producto, cp.Cantidad);
                                db.compras.Update(compra);
                                db.SaveChanges();
                            }

                        }
                    }
                    catch (Exception)
                    {
                        sePudoComprar = false;
                    }
                    sePudoComprar = true;
                }
                else
                {
                    sePudoComprar = false;
                }


            }
            catch (Exception)
            {
                sePudoComprar = false;
            }
            return sePudoComprar;

        }

        public bool ActualizarStockProducto(int idProducto, int cantidad)
        {
            Producto productoEncontrado = db.productos.FirstOrDefault(producto => producto.ProductoId == idProducto);

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
            return db.productos.Where(u => u.ProductoId == Id).FirstOrDefault(); ;
        }

        public Producto BuscarProductoPorNombre(string busca)
        {
            return db.productos.Where(u => u.Nombre.Contains(busca)).FirstOrDefault(); ;
        }

        public List<Producto> BusquedaProductos(string busca)
        {
            return db.productos.Where(u => u.Nombre.Contains(busca)).ToList();
        }

        public List<Producto> MostrarProductoEnPantalla()
        {
            return db.productos.ToList();
        }

        public List<Compra> mostrarComprasRealizadas()
        {
            return db.compras.ToList();
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
            Compra comp = db.compras.Where(c => c.CompraId == id).FirstOrDefault();

            try
            {
                comp.Total = monto;
                db.compras.Update(comp);
                db.SaveChanges();
            }
            catch (Exception)
            {
                salida = false;
            }
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

            if (usuario.TipoUsuario == 1)
                esAdmin = true;

            return esAdmin;
        }

        public void cerrar()
        {
            db.Dispose();
        }

    }
}
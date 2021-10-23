using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace tp_plataformas_2

{
    class Conexion
    {
        List<Categoria> variableAuxiliarCategorias = new List<Categoria>();
        List<Producto> variableAuxiliarProductos = new List<Producto>();
        List<Carro> variableAuxiliarCarros = new List<Carro>();
        List<Usuario> variableAuxiliarUsuarios = new List<Usuario>();
        List<Compra> variableAuxiliarCompras = new List<Compra>();

        //private List<Categoria> variableAuxiliar;

        public Conexion()
        {

            //creaCarros();
        }

        public List<Categoria> getCategorias()
        {
            //Cargo la cadena de conexión desde el archivo de properties
            string connectionString = Properties.Resources.SqlConnect;

            //Defino el string con la consulta que quiero realizar
            string queryString = "SELECT * from dbo.Categoria";

            // Creo una conexión SQL con un Using, de modo que al finalizar, la conexión se cierra y se liberan recursos
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Defino el comando a enviar al motor SQL con la consulta y la conexión
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    //Abro la conexión
                    connection.Open();
                    //mi objecto DataReader va a obtener los resultados de la consulta, notar que a comando se le pide ExecuteReader()
                    SqlDataReader reader = command.ExecuteReader();
                    Categoria auxCategoria;
                    //mientras haya registros/filas en mi DataReader, sigo leyendo
                    while (reader.Read())
                    {
                        auxCategoria = new Categoria(reader.GetInt32(0), reader.GetString(1));
                        variableAuxiliarCategorias.Add(auxCategoria);
                    }
                    //En este punto ya recorrí todas las filas del resultado de la query
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return variableAuxiliarCategorias;
        }

        public List<Producto> getProductos()
        {
            //Cargo la cadena de conexión desde el archivo de properties
            string connectionString = Properties.Resources.SqlConnect;

            //Defino el string con la consulta que quiero realizar
            string queryString = "SELECT * from dbo.Producto";

            // Creo una conexión SQL con un Using, de modo que al finalizar, la conexión se cierra y se liberan recursos
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Defino el comando a enviar al motor SQL con la consulta y la conexión
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    //Abro la conexión
                    connection.Open();
                    //mi objecto DataReader va a obtener los resultados de la consulta, notar que a comando se le pide ExecuteReader()
                    SqlDataReader reader = command.ExecuteReader();

                    //mientras haya registros/filas en mi DataReader, sigo leyendo
                    while (reader.Read())
                    {
                        foreach (Categoria cat in variableAuxiliarCategorias)
                        {
                            var aux = reader.GetInt32(4);
                            if (cat.Id == reader.GetInt32(4))
                            {
                                var precio = (Double)reader.GetDecimal(2);
                                variableAuxiliarProductos.Add(new Producto(reader.GetInt32(0), reader.GetString(1), precio, reader.GetInt32(3), cat));
                            }
                        }
                    }
                    //En este punto ya recorrí todas las filas del resultado de la query
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return variableAuxiliarProductos;
        }

        private void creaCarros()
        {
            string connectionString = Properties.Resources.SqlConnect;


            string queryString = "SELECT * from dbo.Carro";


            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        foreach (Producto producto in variableAuxiliarProductos)
                        {
                            if (producto.Id == reader.GetInt32(1))
                            {

                                variableAuxiliarCarros.Add(new Carro(reader.GetInt32(0), producto, reader.GetInt32(2)));
                            }
                        }
                    }
                    //En este punto ya recorrí todas las filas del resultado de la query
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public List<Usuario> getUsuarios()
        {

            string connectionString = Properties.Resources.SqlConnect;


            string queryString = "SELECT * from dbo.Usuario";


            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        creaCarros();
                        foreach (Carro carro in variableAuxiliarCarros)
                        {

                            if (carro.Id == reader.GetInt32(6))
                            {
                                variableAuxiliarUsuarios.Add(new Usuario(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), carro, reader.GetInt32(7)));
                            }

                        }
                    }
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return variableAuxiliarUsuarios;
        }


        public List<Compra> getCompras()
        {

            string connectionString = Properties.Resources.SqlConnect;


            string queryString = "SELECT c.Id, c.Id_usuario, c.Total, p.Id_producto, p.Cantidad_producto from dbo.Compra c INNER JOIN dbo.Productos_compra p on p.Id_compra = c.Id";

            Dictionary<int, Compra> compras = new Dictionary<int, Compra>();

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Usuario auxUsuario;

                    while (reader.Read())
                    {
                        if (!compras.ContainsKey(reader.GetInt32(3)))
                        {
                            auxUsuario = variableAuxiliarUsuarios.Find(usuario => usuario.Id == reader.GetInt32(1));
                            Compra compra = new Compra(reader.GetInt32(0), auxUsuario, new Dictionary<Producto, int>(), 0);
                            Producto producto = variableAuxiliarProductos.Find(producto => producto.Id == reader.GetInt32(3));
                            int cantidad = reader.GetInt32(4);
                            compra.Productos.Add(producto, cantidad);

                            compras.Add(reader.GetInt32(3), compra);
                            variableAuxiliarCompras.Add(compras[reader.GetInt32(3)]);

                        }
                        else
                        {
                            Producto producto = variableAuxiliarProductos.Find(producto => producto.Id == reader.GetInt32(3));
                            int cantidad = reader.GetInt32(4);

                            compras[reader.GetInt32(3)].Productos.Add(producto, cantidad);
                        }

                    }
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return variableAuxiliarCompras;
        }


        public int cuentaRegistros(string tabla)
        {
            int resultadoQuery;
            string connectionString = Properties.Resources.SqlConnect;
            string queryString = "select MAX(id) from[dbo].[" + tabla + "]";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    //resultadoQuery = command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    resultadoQuery = reader.GetInt32(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return -10;

                }
            }
            return resultadoQuery;
        }
        
        public bool eliminarRegistro(string tabla, int itemId) //no elimina
        {
            int resultadoQuery;
            string connectionString = Properties.Resources.SqlConnect;
            string queryString = "DELETE FROM [dbo].[@tabla] WHERE Id=@id;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@tabla", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                command.Parameters["@tabla"].Value = tabla;
                command.Parameters["@id"].Value = itemId;
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    resultadoQuery = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return resultadoQuery == 1;
        }

        public bool agregarProducto(Producto producto)
        {
            int resultadoQuery;
            string connectionString = Properties.Resources.SqlConnect;
            string queryString = "INSERT INTO [dbo].[Producto] ([Id],[Nombre],[Precio],[Cantidad],[Cat]) VALUES (@Id,@Nombre,@Precio,@Cantidad,@Cat);";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Decimal));
                command.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Cat", SqlDbType.Int));
                command.Parameters["@Id"].Value = producto.Id;
                command.Parameters["@Nombre"].Value = producto.Nombre;
                command.Parameters["@Precio"].Value = producto.Precio;
                command.Parameters["@Cantidad"].Value = producto.Cantidad;
                command.Parameters["@Cat"].Value = producto.Cat.Id;
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    resultadoQuery = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return resultadoQuery == 1;
        }
        public bool modificaProducto(Producto producto) 
        {
            
            int resultadoQuery;
            string connectionString = Properties.Resources.SqlConnect;
            string queryString = "UPDATE [dbo].[Producto] SET Nombre=@nombre, Precio=@precio, Cantidad=@cantidad, Cat=@cat WHERE Id=@id;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@precio", SqlDbType.Decimal));
                command.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@cat", SqlDbType.Int));
                command.Parameters["@id"].Value = producto.Id;
                command.Parameters["@nombre"].Value = producto.Nombre;
                command.Parameters["@precio"].Value = producto.Precio;
                command.Parameters["@cantidad"].Value = producto.Cantidad;
                command.Parameters["@cat"].Value = producto.Cat.Id;
                try
                {
                    connection.Open();
                    resultadoQuery = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            return resultadoQuery == 1;
        
    }
        public bool agregarUsuario(Usuario usuario)
        {
            int resultadoQuery;
            string connectionString = Properties.Resources.SqlConnect;
            string queryString = "INSERT INTO [dbo].[Usuario] ([Id],[CUIL],[Nombre],[Apellido],[Mail],[Password],[MiCarro],[TipoUsuario]) VALUES (@Id,@CUIL,@Nombre,@Apellido,@Mail,@Password,@MiCarro,@TipoUsuario);";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@CUIL", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@Mail", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@MiCarro", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@TipoUsuario", SqlDbType.Int));
                command.Parameters["@Id"].Value = usuario.Id;
                command.Parameters["@CUIL"].Value = usuario.Cuil;
                command.Parameters["@Nombre"].Value = usuario.Nombre;
                command.Parameters["@Apellido"].Value = usuario.Apellido;
                command.Parameters["@Mail"].Value = usuario.Mail;
                command.Parameters["@Password"].Value = usuario.Password;
                command.Parameters["@MiCarro"].Value = usuario.MiCarro.Id;
                command.Parameters["@TipoUsuario"].Value = usuario.TipoUsuario;

                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    resultadoQuery = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return resultadoQuery == 1;
        }

        public bool agregarCompra(Compra compra)
        {
            return false;
        }

        //    public List<List<string>> obtenerUsuarios()
        //    {
        //        List<List<string>> salida = new List<List<string>>();
        //        foreach (Usuario u in misUsuarios)
        //            salida.Add(new List<string>() { u.dni.ToString(), u.nombre, u.mail, u.password, u.esADM.ToString(), u.bloqueado.ToString() });
        //        return salida;
        //    }

        //    public bool agregarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        //    {
        //        //primero me aseguro que lo pueda agregar a la base
        //        int resultadoQuery;
        //        string connectionString = Properties.Resources.ConnectionString;
        //        string queryString = "INSERT INTO [dbo].[Usuarios] ([DNI],[Nombre],[Mail],[Password],[EsADM],[Bloqueado]) VALUES (@dni,@nombre,@mail,@password,@esadm,@bloqueado);";
        //        using (SqlConnection connection =
        //            new SqlConnection(connectionString))
        //        {
        //            SqlCommand command = new SqlCommand(queryString, connection);
        //            command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
        //            command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
        //            command.Parameters.Add(new SqlParameter("@mail", SqlDbType.NVarChar));
        //            command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
        //            command.Parameters.Add(new SqlParameter("@esadm", SqlDbType.Bit));
        //            command.Parameters.Add(new SqlParameter("@bloqueado", SqlDbType.Bit));
        //            command.Parameters["@dni"].Value = Dni;
        //            command.Parameters["@nombre"].Value = Nombre;
        //            command.Parameters["@mail"].Value = Mail;
        //            command.Parameters["@password"].Value = Password;
        //            command.Parameters["@esadm"].Value = EsADM;
        //            command.Parameters["@bloqueado"].Value = Bloqueado;
        //            try
        //            {
        //                connection.Open();
        //                //esta consulta NO espera un resultado para leer, es del tipo NON Query
        //                resultadoQuery = command.ExecuteNonQuery();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //                return false;
        //            }
        //        }
        //        if (resultadoQuery == 1)
        //        {
        //            //Ahora sí lo agrego en la lista
        //            Usuario nuevo = new Usuario(Dni, Nombre, Mail, Password, EsADM, Bloqueado);
        //            misUsuarios.Add(nuevo);
        //            return true;
        //        }
        //        else
        //        {
        //            //algo salió mal con la query porque no generó 1 registro
        //            return false;
        //        }
        //    }

        //    public bool eliminarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        //    {
        //        //primero me aseguro que lo pueda agregar a la base
        //        int resultadoQuery;
        //        string connectionString = Properties.Resources.ConnectionString;
        //        string queryString = "DELETE FROM [dbo].[Usuarios] WHERE DNI=@dni AND Nombre=@nombre AND Mail=@mail AND Password=@password AND EsADM=@esadm AND Bloqueado=@bloqueado;";
        //        using (SqlConnection connection =
        //            new SqlConnection(connectionString))
        //        {
        //            SqlCommand command = new SqlCommand(queryString, connection);
        //            command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
        //            command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
        //            command.Parameters.Add(new SqlParameter("@mail", SqlDbType.NVarChar));
        //            command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
        //            command.Parameters.Add(new SqlParameter("@esadm", SqlDbType.Bit));
        //            command.Parameters.Add(new SqlParameter("@bloqueado", SqlDbType.Bit));
        //            command.Parameters["@dni"].Value = Dni;
        //            command.Parameters["@nombre"].Value = Nombre;
        //            command.Parameters["@mail"].Value = Mail;
        //            command.Parameters["@password"].Value = Password;
        //            command.Parameters["@esadm"].Value = EsADM;
        //            command.Parameters["@bloqueado"].Value = Bloqueado;
        //            try
        //            {
        //                connection.Open();
        //                //esta consulta NO espera un resultado para leer, es del tipo NON Query
        //                resultadoQuery = command.ExecuteNonQuery();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //                return false;
        //            }
        //        }
        //        if (resultadoQuery == 1)
        //        {
        //            try
        //            {
        //                //Ahora sí lo elimino en la lista
        //                for (int i = 0; i < misUsuarios.Count; i++)
        //                    if (misUsuarios[i].dni == Dni)
        //                        misUsuarios.RemoveAt(i);
        //                return true;
        //            }
        //            catch (Exception)
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            //algo salió mal con la query porque no generó 1 registro
        //            return false;
        //        }
        //    }

        //    public bool modificarUsuario(int Dni, string Nombre, string Mail, string Password, bool EsADM, bool Bloqueado)
        //    {
        //        //primero me aseguro que lo pueda agregar a la base
        //        int resultadoQuery;
        //        string connectionString = Properties.Resources.ConnectionString;
        //        string queryString = "UPDATE [dbo].[Usuarios] SET Nombre=@nombre, Mail=@mail,Password=@password, EsADM=@esadm, Bloqueado=@bloqueado WHERE DNI=@dni;";
        //        using (SqlConnection connection =
        //            new SqlConnection(connectionString))
        //        {
        //            SqlCommand command = new SqlCommand(queryString, connection);
        //            command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
        //            command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
        //            command.Parameters.Add(new SqlParameter("@mail", SqlDbType.NVarChar));
        //            command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
        //            command.Parameters.Add(new SqlParameter("@esadm", SqlDbType.Bit));
        //            command.Parameters.Add(new SqlParameter("@bloqueado", SqlDbType.Bit));
        //            command.Parameters["@dni"].Value = Dni;
        //            command.Parameters["@nombre"].Value = Nombre;
        //            command.Parameters["@mail"].Value = Mail;
        //            command.Parameters["@password"].Value = Password;
        //            command.Parameters["@esadm"].Value = EsADM;
        //            command.Parameters["@bloqueado"].Value = Bloqueado;
        //            try
        //            {
        //                connection.Open();
        //                //esta consulta NO espera un resultado para leer, es del tipo NON Query
        //                resultadoQuery = command.ExecuteNonQuery();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //                return false;
        //            }
        //        }
        //        if (resultadoQuery == 1)
        //        {
        //            try
        //            {
        //                //Ahora sí lo MODIFICO en la lista
        //                for (int i = 0; i < misUsuarios.Count; i++)
        //                    if (misUsuarios[i].dni == Dni)
        //                    {
        //                        misUsuarios[i].nombre = Nombre;
        //                        misUsuarios[i].mail = Mail;
        //                        misUsuarios[i].password = Password;
        //                        misUsuarios[i].esADM = EsADM;
        //                        misUsuarios[i].bloqueado = Bloqueado;
        //                    }
        //                return true;
        //            }
        //            catch (Exception)
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            //algo salió mal con la query porque no generó 1 registro
        //            return false;
        //        }
        //    }
        //}
    }
}


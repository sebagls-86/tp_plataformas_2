using System;
using System.Collections.Generic;

namespace tp_plataformas_2
{
    public abstract class MercadoHelper
    {

        public static bool SonMenoresACero(List<int> numeros) => numeros.Exists(numero => numero < 0);

        public static bool ExisteElUsuario(int idUsuario, List<Usuario> usuarios)
        {
            try
            {
                return usuarios[idUsuario] != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        public static bool ExisteElProducto(int idProducto, List<Producto> productos)  {
            try
            {
                return productos[idProducto] != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

    }
}

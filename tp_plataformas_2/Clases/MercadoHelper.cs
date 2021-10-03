using System;
using System.Collections.Generic;

namespace tp_plataformas_2
{
    public abstract class MercadoHelper
    {

        public static bool SonMenoresACero(List<int> numeros) => numeros.Exists(numero => numero < 0);

        public static bool ExisteElUsuario(int idUsuario, List<Usuario> usuarios) =>  usuarios[idUsuario - 1] != null;

        public static bool ExisteElProducto(int idProducto, List<Producto> productos)  =>  productos[idProducto] != null;

        public static double CalcularPorcentaje(Double valor, Double porcentaje)
        {
            double valorFinal = valor - ((valor * porcentaje) % 100);
            return valorFinal;
        }

    }
}

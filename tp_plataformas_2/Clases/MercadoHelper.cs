using System;
using System.Collections.Generic;

namespace tp_plataformas_2
{
    public abstract class MercadoHelper
    {

        public static bool SonMenoresACero(List<int> numeros) => numeros.Exists(numero => numero < 0);

        public static double CalcularPorcentaje(Double valor, Double porcentaje)
        {
            double valorFinal = valor + ((valor * porcentaje) / 100);
            return valorFinal;
        }

    }
}

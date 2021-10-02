using System;

namespace tp_plataformas_2
{
    class ClienteFinal : Usuario
    {

        public int Cuil { get; set; }


        public ClienteFinal(int id, int dni, String nombre, String apellido, String mail, String password, Carro carro, int cuil, bool esAdmin) : base(id, dni, nombre, apellido, mail, password, carro, esAdmin)
        {
            Cuil = cuil;
        }



        public override string ToString()
        {

            return $"{Id} {"-"} {Nombre} {"-"} {Apellido} {"-"} {Mail}" +
                $"{"-"} {Password} {"-"} {Cuil}";

        }
    }
}

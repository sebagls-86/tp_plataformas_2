using System;
using System.Collections.Generic;


namespace tp_plataformas_2
{
    public class Usuario : IComparable<Usuario>
    {

        public int UsuarioId { get; set; }
        public int Cuil { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public Carro Carro { get; set; }
        public int MiCarro { get; set; }
        public int TipoUsuario { get; set; }
        public List<Compra> Compra { get; set; }


        public Usuario(int cuil, string nombre, string apellido, string mail, string password, int MiCarro, int tipoUsuario)
        {
            Carro = new Carro();
            Cuil = cuil;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Password = password;
            Carro.CarroId = MiCarro;
            TipoUsuario = tipoUsuario;
        }

        public Usuario() {}

        public int CompareTo(Usuario other)
        {
            return Cuil.CompareTo(other.Cuil);
        }

        public override string ToString()
        {
            return $"{UsuarioId}|{Cuil}|{Nombre}|{Apellido}|{Mail}|{Password}|{TipoUsuario}";
        }

        public string[] toArray()
        {
            return new string[] { UsuarioId.ToString(), Cuil.ToString(), Nombre.ToString(), Apellido.ToString(), Mail.ToString(),
                MiCarro.ToString(),TipoUsuario.ToString() };
        }
    }
}

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
        public Carro MiCarro { get; set; }
        public int TipoUsuario { get; set; }

        

        public Usuario(int id, int cuil, string nombre, string apellido, string mail, string password, Carro carro, int tipoUsuario)
        {
            UsuarioId = id;
            Cuil = cuil;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Password = password;
            MiCarro = carro;
            TipoUsuario = tipoUsuario;
        }

       

        public int CompareTo(Usuario other)
        {
            return Cuil.CompareTo(other.Cuil);
        }

        public override string ToString()
        {
            return $"{UsuarioId}|{Cuil}|{Nombre}|{Apellido}|{Mail}|{Password}|{TipoUsuario}";
        }
    }
}

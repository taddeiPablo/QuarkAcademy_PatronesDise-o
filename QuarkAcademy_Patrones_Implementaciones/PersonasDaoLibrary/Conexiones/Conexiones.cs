using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonasDaoLibrary.Interface;

namespace PersonasDaoLibrary.Conexiones
{
    public class Conexiones : Iconexiones
    {
        private string usuario;
        private string password;
        private string connection;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Connection { get => connection; set => connection = value; }
        public string Password { get => password; set => password = value; }

        public Conexiones(string usuario, string conn, string password)
        {
            this.usuario = usuario;
            this.connection = conn;
            this.password = password;
        }

        public void conectar()
        {
            throw new NotImplementedException();
        }
    }
}

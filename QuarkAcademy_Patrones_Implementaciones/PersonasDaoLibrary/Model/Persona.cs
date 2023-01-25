using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasDaoLibrary.Model
{
    public class Persona
    {
        private string nombre;
        private int id;
        private string apellido;

        public Persona(string nombre, string apellido, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
        }

        public Persona()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return nombre + "   ;   " + apellido + "    ;   " + id;
        }

    }
}

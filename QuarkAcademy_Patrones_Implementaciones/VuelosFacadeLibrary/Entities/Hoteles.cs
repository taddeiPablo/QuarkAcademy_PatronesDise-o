using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelosFacadeLibrary.Entities
{
    public class Hoteles
    {
        private string llegada;
        private string salida;
        private string lugar;

        public string Llegada { get => llegada; set => llegada = value; }
        public string Salida { get => salida; set => salida = value; }
        public string Lugar { get => lugar; set => lugar = value; }

        public Hoteles(string llegada, string salida, string lugar)
        {
            this.llegada = llegada;
            this.salida = salida;
            this.lugar = lugar;
        }
    }
}

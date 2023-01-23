using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica_mueble_Library.Interface;

namespace Fabrica_mueble_Library.Muebles
{
    public class Sofa : IMueble
    {

        private string marca;
        private string modelo;
        private string ancho;
        private string profundidad;
        private string tipo_material;

        private StringBuilder strBuilder;

        [DisplayName("Marca")]
        public string Marca { get => marca; set => marca = value; }
        [DisplayName("Modelo")]
        public string Modelo { get => modelo; set => modelo = value; }
        [DisplayName("Ancho")]
        public string Ancho { get => ancho; set => ancho = value; }
        [DisplayName("Profundidad")]
        public string Profundidad { get => profundidad; set => profundidad = value; }
        [DisplayName("Tipo de Material")]
        public string Tipo_material { get => tipo_material; set => tipo_material = value; }

        public Sofa(string marca, string modelo, string ancho, string profundidad, string tipoMaterial)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ancho = ancho;
            this.profundidad = profundidad;
            this.tipo_material = tipoMaterial;
            strBuilder = new StringBuilder();
        }


        public override string ToString()
        {
            return strBuilder.ToString();
        }

        public void Visualizar()
        {
            if (strBuilder.Length == 0)
                strBuilder.Append("Sofa : " + marca + " | " + modelo + " | " + ancho + " | " + profundidad + " | " + tipo_material + " | ");
        }
    }
}

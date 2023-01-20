﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fabrica_mueble_Library.Interface;

namespace Fabrica_mueble_Library.Muebles
{
    public class Mesilla : IMueble
    {
        private string marca;
        private string modelo;
        private string ancho;
        private string profundidad;
        private string tipo_material;
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Ancho { get => ancho; set => ancho = value; }
        public string Profundidad { get => profundidad; set => profundidad = value; }
        public string Tipo_material { get => tipo_material; set => tipo_material = value; }

        public Mesilla(string marca, string modelo, string ancho, string profundidad, string tipoMaterial)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ancho = ancho;
            this.profundidad = profundidad;
            this.tipo_material = tipoMaterial;
        }

        public void Construir()
        {
            throw new NotImplementedException();
        }
    }
}
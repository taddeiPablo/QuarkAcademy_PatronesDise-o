using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscograficaBuilderLibrary.Entidades
{
    public class MaterialDiscografico
    {
        private string nombre;
        private double precio;
        private int stock;
        private int duracionTotalSegundos;

        private Genero genero;
        private Autor autor;
        private TipoMaterialDiscografico tipoMaterialDiscografico;
        private List<Cancion> lista_de_canciones;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int DuracionTotalSegundos { get => duracionTotalSegundos; set => duracionTotalSegundos = value; }
        public Genero Genero { get => genero; set => genero = value; }
        public Autor Autor { get => autor; set => autor = value; }
        public TipoMaterialDiscografico TipoMaterialDiscografico { get => tipoMaterialDiscografico; set => tipoMaterialDiscografico = value; }
        public List<Cancion> Lista_de_canciones { get => lista_de_canciones; set => lista_de_canciones = value; }

        public String datosCanciones()
        {
            int numeroDeCancion = 1;
            String datos = "\nCANCIONES";

            foreach (Cancion cancion in this.lista_de_canciones)
            {
                datos +=
                    "\nNº " + numeroDeCancion.ToString() +
                    "\nNombre: " + cancion.NombreCancion +
                    "\nDuracion: " + cancion.DuracionSegundos.ToString() + " segundos";

                numeroDeCancion++;
            }
            return datos;
        }

        public String reportarDatos()
        {
            return "REPORTE DE MATERIAL" +
                   "\nNombre: " + nombre +
                   "\nPrecio: " + precio +
                   "\nStock: " + stock +
                   "\nDuracion total: " + duracionTotalSegundos + " segundos" +
                   "\n--------------------" +
                   "\nAUTOR" +
                   "\nNombre: " + autor.NombreArtista +
                   "\nDescripcion: " + autor.DescripcionArtista +
                   "\n--------------------" +
                   "\nGENERO" +
                   "\nNombre: " + genero.DescripcionGenero +
                   "\n--------------------" +
                   "\nTIPO MATERIAL DISCOGRAFICO" +
                   "\nNombre: " + tipoMaterialDiscografico.NombreTipoMaterialDiscografico +
                   "\n--------------------" +
                   datosCanciones();
        }

    }
}

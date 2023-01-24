using DiscograficaBuilderLibrary.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscograficaBuilderLibrary.Builder
{
    public class MaterialDiscograficoBuilder : IMaterialDiscograficoBuilder
    {
        private string nombre;
        private double precio;
        private int stock;

        private Genero genero;
        private Autor autor;
        private TipoMaterialDiscografico tipoMaterialDiscografico;
        private List<Cancion> listaCanciones;


        public MaterialDiscograficoBuilder ComoAutor(Autor autor)
        {
            this.autor = autor;
            return this;
        }

        public MaterialDiscograficoBuilder ComoGenero(Genero genero)
        {
            this.genero = genero;
            return this;
        }

        public MaterialDiscograficoBuilder ComoLista(List<Cancion> canciones)
        {
            this.listaCanciones = canciones;
            return this;
        }

        public MaterialDiscograficoBuilder ComoTipoMaterialDiscografico(TipoMaterialDiscografico mtDiscografico)
        {
            this.tipoMaterialDiscografico = mtDiscografico;
            return this;
        }

        public MaterialDiscograficoBuilder ConNombre(string nombre)
        {
            this.nombre = nombre;
            return this;
        }

        public MaterialDiscograficoBuilder EnStock(int stock)
        {
            this.stock = stock;
            return this;
        }

        public MaterialDiscograficoBuilder TienePrecio(double precio)
        {
            this.precio = precio;
            return this;
        }

        private int calcularDuracionTotalSegundos()
        {
            int duracionTotal = 0;

            foreach (Cancion cancion in listaCanciones)
            {
                duracionTotal += cancion.DuracionSegundos;
            }

            return duracionTotal;
        }


        public MaterialDiscografico BuildMaterialDiscografico()
        {
            return new MaterialDiscografico()
            {

                Nombre = this.nombre,
                Precio = this.precio,
                Stock = this.stock,
                DuracionTotalSegundos = calcularDuracionTotalSegundos(),
                Genero = this.genero,
                Autor = this.autor,
                TipoMaterialDiscografico = this.tipoMaterialDiscografico,
                Lista_de_canciones = this.listaCanciones

            };
        }

    }
}

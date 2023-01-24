using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscograficaBuilderLibrary.Entidades;

namespace DiscograficaBuilderLibrary.Builder
{
    public interface IMaterialDiscograficoBuilder
    {
        MaterialDiscograficoBuilder ConNombre(string nombre);
        MaterialDiscograficoBuilder TienePrecio(Double precio);
        MaterialDiscograficoBuilder EnStock(int stock);
        MaterialDiscograficoBuilder ComoGenero(Genero genero);
        MaterialDiscograficoBuilder ComoAutor(Autor autor);
        MaterialDiscograficoBuilder ComoTipoMaterialDiscografico(TipoMaterialDiscografico mtDiscografico);
        MaterialDiscograficoBuilder ComoLista(List<Cancion> canciones);

    }
}

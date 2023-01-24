using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColoresFactoryLibrary.Interface;
using ColoresFactoryLibrary.colores;

namespace ColoresFactoryLibrary
{
    public class ColoresFactory
    {
        private IColores colores;
        
        public IColores getColores(string tipo)
        {
            if (tipo == "azul")
            {
                colores = new GamaAzul();
            }else if(tipo == "rojo")
            {
                colores = new GamaRojo();
            }else if(tipo == "amarillo")
            {
                colores = new GamaAmarillo();
            }
            return colores;
        }
    }
}

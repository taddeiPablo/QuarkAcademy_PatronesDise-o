using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColoresFactoryLibrary.Interface;

namespace ColoresFactoryLibrary.colores
{
    public class GamaRojo : IColores
    {
        private Color colorGamaRojo;
        private string color_en_hexa;
        private int g = 10;
        private int b = 10;
        Color newColor;
        public string Color_en_hexa 
        {
            get => color_en_hexa;
        }

        public GamaRojo()
        {
            colorGamaRojo = Color.FromArgb(255, 0, 0);
        }

        public Color getNewColor(Color actual)
        {
            int newG = actual.G + g;
            int newB = actual.B + b;
            if (newG == 257 || newB == 257)
            {
                newColor = Color.FromArgb(actual.R, 255, 255);
            }
            else if (newB > 255 && newG > 255)
            {
                throw new Exception("SE TERMINO LA GAMA DE COLORES PARA EL ROJO");
            }
            else
            {
                newColor = Color.FromArgb(actual.R, newG, newB);
            }
            color_en_hexa = "#" + newColor.R.ToString("X2") + newColor.G.ToString("X2") + newColor.B.ToString("X2");
            return newColor;
        }
        public string getHexaColor()
        {
            return color_en_hexa;
        }
    }
}

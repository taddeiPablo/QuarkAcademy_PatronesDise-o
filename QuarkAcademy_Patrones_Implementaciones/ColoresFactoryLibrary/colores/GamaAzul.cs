using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ColoresFactoryLibrary.Interface;

namespace ColoresFactoryLibrary.colores
{
    public class GamaAzul: IColores     
    {
        private Color colorGamaAzul;
        private string color_en_hexa;
        private int r = 10;
        private int g = 10;
        Color newColor;
        public string Color_en_hexa 
        {
            get => color_en_hexa;
        }

        public GamaAzul()
        {
            colorGamaAzul = Color.FromArgb(0, 0, 255);
        }

        public Color getNewColor(Color actual)
        {
            int newR = actual.R + r;
            int newG = actual.G + g;
            if (newR == 257 || newG == 257)
            {
                newColor = Color.FromArgb(255, 255, actual.B);
            }
            else if(newR > 255 && newG > 255)
            {
                throw new Exception("SE TERMINO LA GAMA DE COLORES PARA EL AZUL");
            }
            else
            {
                newColor = Color.FromArgb(newR, newG, actual.B);
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

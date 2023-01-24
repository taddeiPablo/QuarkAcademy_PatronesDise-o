using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColoresFactoryLibrary.Interface;

namespace ColoresFactoryLibrary.colores
{
    public class GamaAmarillo : IColores
    {
        private Color colorGamaAmarillo;
        private string color_en_hexa;
        private int b = 10;
        Color newColor;
        public string Color_en_hexa 
        {
            get => color_en_hexa;
        }

        public GamaAmarillo()
        {
            colorGamaAmarillo = Color.FromArgb(255, 251, 0);
        }

        public Color getNewColor(Color actual)
        {
            int newB = actual.B + b;
            if (newB == 257)
            {
                newColor = Color.FromArgb(255, 255, 255);
            }
            else if (newB > 255)
            {
                throw new Exception("SE TERMINO LA GAMA DE COLORES PARA EL AMARILLO");
            }
            else
            {
                newColor = Color.FromArgb(actual.R, actual.G, newB);
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

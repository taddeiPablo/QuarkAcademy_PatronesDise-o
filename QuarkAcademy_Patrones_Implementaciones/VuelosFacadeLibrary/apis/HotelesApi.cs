using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VuelosFacadeLibrary.Entities;

namespace VuelosFacadeLibrary.apis
{
    public class HotelesApi
    {
        private List<Hoteles> listado_de_hoteles;
        private bool noencontrado = true;
        public HotelesApi()
        {
            listado_de_hoteles = new List<Hoteles>();
            listado_de_hoteles.Add(new Hoteles("1/26/2023","2/06/2023","Tokyo"));
            listado_de_hoteles.Add(new Hoteles("2/04/2023", "3/30/2023", "Montevideo"));
            listado_de_hoteles.Add(new Hoteles("3/05/2023", "4/20/2023", "Sao Paulo"));
            listado_de_hoteles.Add(new Hoteles("4/06/2023", "4/29/2023", "Madrid"));
            listado_de_hoteles.Add(new Hoteles("7/07/2023", "7/20/2023", "Paris"));
            listado_de_hoteles.Add(new Hoteles("10/11/2023", "30/11/2023", "Londres"));
        }

        public void buscarHoteles(string llegada, string salida, string lugar)
        {
            foreach (Hoteles hotel in listado_de_hoteles)
            {
                if (hotel.Llegada == llegada && hotel.Salida == salida && hotel.Lugar == lugar)
                {
                    noencontrado = false;
                    Console.WriteLine("===============================================================");
                    Console.WriteLine("Hotel encontrado para : ");
                    Console.WriteLine(hotel.Llegada);
                    Console.WriteLine(hotel.Salida);
                    Console.WriteLine(hotel.Lugar);
                    Console.WriteLine("===============================================================");
                }
            }
            if (noencontrado)
            {
                throw new Exception("hotel no encontrado");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VuelosFacadeLibrary.Entities;

namespace VuelosFacadeLibrary.apis
{
    public class AvionesApi
    {

        private List<Vuelos> listado_de_vuelos;
        private bool noencontrado = true;
        public AvionesApi()
        {
            listado_de_vuelos = new List<Vuelos>();
            listado_de_vuelos.Add(new Vuelos("1/26/2023", "2/28/2023", "Buenos Aires", "Tokyo"));
            listado_de_vuelos.Add(new Vuelos("2/26/2023", "3/28/2023", "Buenos Aires", "Madrid"));
            listado_de_vuelos.Add(new Vuelos("3/26/2023", "4/28/2023", "Santiago de Chile", "Mexico DF"));
            listado_de_vuelos.Add(new Vuelos("3/28/2023", "5/28/2023", "São Paulo", "Miami"));
            listado_de_vuelos.Add(new Vuelos("1/26/2023", "2/28/2023", "Buenos Aires", "Londres"));
            listado_de_vuelos.Add(new Vuelos("1/26/2023", "2/28/2023", "Lima", "Buenos Aires"));
            listado_de_vuelos.Add(new Vuelos("5/26/2023", "6/28/2023", "Montevideo", "Paris"));
            listado_de_vuelos.Add(new Vuelos("6/20/2023", "6/30/2023", "Quito", "Buenos Aires"));
            listado_de_vuelos.Add(new Vuelos("1/26/2023", "2/28/2023", "Washington DC", "Montevideo"));
            listado_de_vuelos.Add(new Vuelos("8/02/2023", "8/28/2023", "Camberra", "Tokyo"));
            listado_de_vuelos.Add(new Vuelos("9/20/2023", "10/20/2023", "Buenos Aires", "Tokyo"));
            listado_de_vuelos.Add(new Vuelos("10/05/2023", "10/28/2023","Buenos Aires" ,"Beijing"));
        }

        public void buscarVuelos(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            foreach (Vuelos vuelo in listado_de_vuelos)
            {
                if (vuelo.FechaIda == fechaIda && vuelo.FechaVuelta == fechaVuelta
                    && vuelo.Origen == origen && vuelo.Destino == destino)
                {
                    noencontrado = false;
                    Console.WriteLine("===============================================================");
                    Console.WriteLine("vuelo encontrado para : ");
                    Console.WriteLine(vuelo.FechaIda);
                    Console.WriteLine(vuelo.FechaVuelta);
                    Console.WriteLine(vuelo.Origen);
                    Console.WriteLine(vuelo.Destino);
                    Console.WriteLine("===============================================================");
                }
            }
            if (noencontrado)
            {
                throw new Exception("no se encontraron vuelos");
            }
        }
    }
}

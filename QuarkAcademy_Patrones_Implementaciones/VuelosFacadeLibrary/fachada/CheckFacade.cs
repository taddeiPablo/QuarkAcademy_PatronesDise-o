using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VuelosFacadeLibrary.apis;

namespace VuelosFacadeLibrary.fachada
{
    public class CheckFacade
    {
        private AvionesApi vuelosApi;
        private HotelesApi hoteles_api;

        public CheckFacade()
        {
            vuelosApi = new AvionesApi();
            hoteles_api = new HotelesApi();
        }
        public void buscar(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            vuelosApi.buscarVuelos(fechaIda, fechaVuelta, origen, destino);
        }
        public void buscar(string llegada, string salida, string lugar)
        {
            hoteles_api.buscarHoteles(llegada, salida, lugar);
        }
    }
}

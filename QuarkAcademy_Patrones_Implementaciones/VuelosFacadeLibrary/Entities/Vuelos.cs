using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelosFacadeLibrary.Entities
{
    public class Vuelos
    {
        private string fechaIda;
        private string fechaVuelta;
        private string origen;
        private string destino;

        public string FechaIda { get => fechaIda; set => fechaIda = value; }
        public string FechaVuelta { get => fechaVuelta; set => fechaVuelta = value; }
        public string Origen { get => origen; set => origen = value; }
        public string Destino { get => destino; set => destino = value; }

        public Vuelos(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            this.fechaIda = fechaIda;
            this.fechaVuelta = fechaVuelta;
            this.origen = origen;
            this.destino = destino;
        }
    }
}

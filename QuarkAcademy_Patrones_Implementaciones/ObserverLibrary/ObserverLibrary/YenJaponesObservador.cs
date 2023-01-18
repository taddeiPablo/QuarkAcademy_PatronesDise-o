using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.ObserverLibrary
{
    public class YenJaponesObservador : Observador
    {
        private double valorCambio = 0.70;
        private double result = 0.0;

        public double Result
        {
            get { return this.result; }
        }

        public YenJaponesObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this);
        }

        public override void actualizar()
        {
            result = sujeto.Estado * valorCambio;
        }
     }
}

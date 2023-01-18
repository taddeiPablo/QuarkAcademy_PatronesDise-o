using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.ObserverLibrary
{
    public class PesoArgObservador : Observador
    {
        private double valorCambio = 182.83;
        public PesoArgObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this);
        }

        // pensar como actualizar el label que correponda
        public override void actualizar()
        {
            throw new NotImplementedException();
        }
    }
}

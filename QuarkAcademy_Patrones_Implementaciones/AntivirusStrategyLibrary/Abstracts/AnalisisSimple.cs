using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AntivirusStrategyLibrary.Interfaces;

namespace AntivirusStrategyLibrary.Abstracts
{
    public abstract class AnalisisSimple : IEstrategias
    {
        public void analizar()
        {
            iniciar();
            analisis_Superficial();
            detener();
        }

        public abstract void iniciar();
        public abstract void analisis_Superficial();
        public abstract void detener();
    }
}

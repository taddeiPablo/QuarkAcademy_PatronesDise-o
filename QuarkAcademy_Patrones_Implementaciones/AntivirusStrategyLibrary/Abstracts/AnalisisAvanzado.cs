using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AntivirusStrategyLibrary.Interfaces;

namespace AntivirusStrategyLibrary.Abstracts
{
    public abstract class AnalisisAvanzado : IEstrategias
    {
        public void analizar()
        {
            iniciar();
            analisis_profundo();
            detener();
        }

        public abstract void iniciar();
        public abstract void analisis_profundo();
        public abstract void detener();
    }
}

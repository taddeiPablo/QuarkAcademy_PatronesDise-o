using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AntivirusStrategyLibrary.Interfaces;

namespace AntivirusStrategyLibrary
{
    public class Contexto
    {
        private IEstrategias estrategia;

        public Contexto(IEstrategias estrategia)
        {
            this.estrategia = estrategia;
        }
        public void ejecutar()
        {
            this.estrategia.analizar();
        }
    }
}

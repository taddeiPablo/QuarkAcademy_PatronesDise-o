using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using AntivirusStrategyLibrary.Abstracts;

namespace AntivirusStrategyLibrary.Entities
{
    public class AntivirusAvanzado : AnalisisAvanzado
    {
        public override void analisis_profundo()
        {
            Console.WriteLine("analisis de memoria a comenzado");
            Thread.Sleep(500);
            Console.WriteLine("analisis de memoria finalizado");
        }

        public override void detener()
        {
            Console.WriteLine("analiziz avanzado terminado");
        }

        public override void iniciar()
        {
            Console.WriteLine("comenzando el analisis avanzado");
        }
    }
}

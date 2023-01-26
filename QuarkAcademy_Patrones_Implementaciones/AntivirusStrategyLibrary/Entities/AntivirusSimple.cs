using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AntivirusStrategyLibrary.Abstracts;

namespace AntivirusStrategyLibrary.Entities
{
    public class AntivirusSimple : AnalisisSimple
    {
        public override void analisis_Superficial()
        {
            Console.WriteLine("inicializando el analisis");
        }

        public override void detener()
        {
            Console.WriteLine("antivirus simple a finalizado");
        }

        public override void iniciar()
        {
            Console.WriteLine("inicializando el analisis");
        }
    }
}

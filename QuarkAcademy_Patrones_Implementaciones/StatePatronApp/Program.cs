using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatronApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch _switch = new Switch();
            Console.WriteLine("Aplicando el patron state");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            _switch.Presionar();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

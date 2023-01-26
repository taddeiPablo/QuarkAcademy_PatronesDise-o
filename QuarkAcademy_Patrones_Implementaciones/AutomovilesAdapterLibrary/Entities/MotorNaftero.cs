using AutomovilesAdapterLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomovilesAdapterLibrary.Entities
{
    public class MotorNaftero : Motor
    {
        public override void acelerar()
        {
            Console.WriteLine("acelerando el motor");
        }

        public override void apagar()
        {
            Console.WriteLine("apagando el motor");
        }

        public override void arrancar()
        {
            Console.WriteLine("arrancando el motor");
        }

        public override void cargarCombustible()
        {
            Console.WriteLine("cargando combustible solo nafta ");
        }
    }
}

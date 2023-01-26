using AutomovilesAdapterLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomovilesAdapterLibrary.Entities
{
    public class MotorDiesel : Motor
    {
        public override void acelerar()
        {
            Console.WriteLine("acelerando este motor diesel");
        }

        public override void apagar()
        {
            Console.WriteLine("apagando el motor");
        }

        public override void arrancar()
        {
            Console.WriteLine("poniendo en marcha el motor");
        }

        public override void cargarCombustible()
        {
            Console.WriteLine("cargando combustible en este caso solo gasoil");
        }
    }
}

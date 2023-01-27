using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomovilesAdapterLibrary.Entities
{
    public class MotorElectrico
    {
        public void conectar()
        {
            Console.WriteLine("conectando el cargador");
        }
        public void Activar()
        {
            Console.WriteLine("activando la unidad");
        }
        public void Mover()
        {
            Console.WriteLine("moviendo la unidad");
        }
        public void Parar()
        {
            Console.WriteLine("frenando la unidad");
        }
        public void desconectar()
        {
            Console.WriteLine("desconectando la unidad");
        }
        public void desactivar()
        {
            Console.WriteLine("apagando la unidad");
        }
        public void enchufar()
        {
            Console.WriteLine("enchufando el cargador de la unidad");
        }
    }
}

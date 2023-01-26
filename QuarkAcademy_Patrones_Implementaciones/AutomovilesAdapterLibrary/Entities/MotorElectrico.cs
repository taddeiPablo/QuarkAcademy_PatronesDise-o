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
            Console.WriteLine("moviendo el auto");
        }
        public void Parar()
        {
            Console.WriteLine("frenando");
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
            Console.WriteLine("enchufando al cargador esta unidad");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeCuentasBancariasLibrary.Interface;
using PrototypeCuentasBancariasLibrary.Cuentas;

namespace CuentasBancariasPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("cuarto ejemplo de patron ( Prototype)");
            CuentaAHImpl cuenta1 = new CuentaAHImpl("AHORRO");
            cuenta1.Monto = 300;
            Console.WriteLine("valores de esta cuenta original");
            Console.WriteLine(cuenta1.Monto);
            Console.WriteLine("ahora vamos a clonar esta cuenta");
            CuentaAHImpl cuentaClone = (CuentaAHImpl)cuenta1.clonar();
            if (cuentaClone != null)
            {
                Console.WriteLine("se creo esta cuenta nueva clone de la cuenta1");
            }
            Console.WriteLine("COMPAREMOS LAS DOS CUENTAS");
            Console.WriteLine("cuenta 1");
            Console.WriteLine(cuenta1.Tipo);
            Console.WriteLine(cuenta1.Monto);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("cuenta 2");
            Console.WriteLine(cuentaClone.Tipo);
            Console.WriteLine(cuentaClone.Monto);
            Console.ReadLine();

        }
    }
}

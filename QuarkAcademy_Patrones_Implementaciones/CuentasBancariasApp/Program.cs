using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CuentaBancariaCommandLibrary;
using CuentaBancariaCommandLibrary.Implementaciones;
using CuentaBancariaCommandLibrary.Interface;
using CuentaBancariaCommandLibrary.Invoker;
using CuentaBancariaCommandLibrary.Receiver;

namespace CuentasBancariasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("IMPLEMENTACION DEL PATRON COMMMAND");
            Console.WriteLine("-------------------------------------------------------");
            Cuenta micuenta = new Cuenta(1, 5000);

            DepositarImp depositarImplementacion = new DepositarImp(micuenta, 1000);
            RetirarImp retirarImplementacion = new RetirarImp(micuenta, 500);

            Invoker ivk = new Invoker();
            ivk.recibirOperacion(depositarImplementacion);
            ivk.recibirOperacion(retirarImplementacion);

            ivk.realizarOperaciones();

            Console.WriteLine("--------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

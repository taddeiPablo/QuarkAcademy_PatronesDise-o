using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancariaCommandLibrary.Receiver
{
    public class Cuenta
    {
        private int id;
        private double saldo;

        public Cuenta(int id, double saldo)
        {
            this.id = id;
            this.saldo = saldo;
        }

        public void retirar(double monto)
        {
            this.saldo = this.saldo - monto;
            Console.WriteLine("se procede a retirar el siguiente monto : " + monto);
            Console.WriteLine("saldo restante : " + this.saldo);
        }

        public void depositar(double monto)
        {
            this.saldo = this.saldo + monto;
            Console.WriteLine("Se procede a depositar el sigueinte monto : " + monto);
            Console.WriteLine("saldo restante : " + this.saldo);
        }
    }
}

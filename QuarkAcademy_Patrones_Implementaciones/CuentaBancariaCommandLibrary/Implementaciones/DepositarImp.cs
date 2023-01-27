using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuentaBancariaCommandLibrary.Receiver;
using CuentaBancariaCommandLibrary.Interface;

namespace CuentaBancariaCommandLibrary.Implementaciones
{
    public class DepositarImp : IOperation
    {
        private Cuenta cuenta;
        private double monto;

        public DepositarImp(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }

        public void execute()
        {
            this.cuenta.depositar(this.monto);
        }
    }
}

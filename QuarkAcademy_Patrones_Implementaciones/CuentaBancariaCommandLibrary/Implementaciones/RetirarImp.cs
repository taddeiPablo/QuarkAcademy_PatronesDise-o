using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CuentaBancariaCommandLibrary.Interface;
using CuentaBancariaCommandLibrary.Receiver;

namespace CuentaBancariaCommandLibrary.Implementaciones
{
    public class RetirarImp : IOperation
    {
        private Cuenta cuenta;
        private double monto;

        public RetirarImp(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }

        public void execute()
        {
            this.cuenta.retirar(this.monto);
        }
    }
}

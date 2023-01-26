using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeCuentasBancariasLibrary.Interface;

namespace PrototypeCuentasBancariasLibrary.Cuentas
{
    public class CuentaAHImpl : ICuenta
    {
        private string tipo;
        private double monto;
        public double Monto
        {
            get { return this.monto; }
            set { this.monto = value; }
        }

        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public CuentaAHImpl(string tipoCuenta)
        {
            tipo = tipoCuenta;
        }
        public ICuenta clonar()
        {
            CuentaAHImpl cuenta = null;
            try
            {
                cuenta = (CuentaAHImpl)Clone();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cuenta;
        }
        // ATENCION : este metodo debemos implementarlo ya que es propio de la interface 
        // simplemente devolvemos la propia instancia con this.
        public object Clone()
        {
            return this;
        }
        // como dato de color sobreescribimos el metodo tostring
        public override string ToString()
        {
            return "CuentaAHImpl : su cuenta de ahorros ya esta abierta y funcionando";
        }
    }
}

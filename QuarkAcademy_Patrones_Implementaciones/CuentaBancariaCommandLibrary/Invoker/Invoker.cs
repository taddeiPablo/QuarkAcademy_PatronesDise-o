using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CuentaBancariaCommandLibrary.Interface;
using CuentaBancariaCommandLibrary.Receiver;

namespace CuentaBancariaCommandLibrary.Invoker
{
    public class Invoker
    {
        private List<IOperation> lista_de_operaciones;

        public Invoker()
        {
            lista_de_operaciones = new List<IOperation>();
        }

        public void recibirOperacion(IOperation operacion)
        {
            this.lista_de_operaciones.Add(operacion);
        }

        public void realizarOperaciones()
        {
            foreach (IOperation ope in this.lista_de_operaciones)
            {
                ope.execute();
            }
            this.lista_de_operaciones.Clear();
        }
    }
}

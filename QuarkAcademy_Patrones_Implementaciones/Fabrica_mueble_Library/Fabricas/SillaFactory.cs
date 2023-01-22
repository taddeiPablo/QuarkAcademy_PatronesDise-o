using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica_mueble_Library.Interface;
using Fabrica_mueble_Library.Muebles;

namespace Fabrica_mueble_Library.Fabricas
{
    public class SillaFactory : IAbstractFactory
    {
        private IMueble NuevoMueble;

        public IMueble getSilla(string tipo)
        {
            if (tipo == "Art Deco")
            {
                NuevoMueble = new Silla("Art", tipo, "50cm", "50cm", "30cm");
            }
            else if (tipo == "victoriana")
            {
                NuevoMueble = new Silla("Art",tipo,"60cm","60cm","40cm");
            }
            else if (string.Equals(tipo, "Moderna"))
            {
                NuevoMueble = new Silla("Art",tipo,"40cm","50cm","35cm");
            }
            return NuevoMueble;
        }

        #region metodos que no se implementan en esta fabrica
        public IMueble getSofa(string tipo)
        {
            throw new NotImplementedException();
        }
        public IMueble getMesilla(string tipo)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

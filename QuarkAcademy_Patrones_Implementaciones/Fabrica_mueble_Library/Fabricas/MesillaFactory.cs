using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fabrica_mueble_Library.Interface;
using Fabrica_mueble_Library.Muebles;

namespace Fabrica_mueble_Library.Fabricas
{
    public class MesillaFactory : IAbstractFactory
    {
        private IMueble NuevoMueble;

        public IMueble getMesilla(string tipo)
        {
            if (tipo == "Art Deco")
            {
                NuevoMueble = new Mesilla("Nuevo", tipo, "50cm", "70cm", "90cm");
            }
            else if (tipo == "victoriana")
            {
                NuevoMueble = new Mesilla("Arg",tipo,"80cm","90cm","30cm");
            }
            else if (string.Equals(tipo, "Moderna"))
            {
                NuevoMueble = new Mesilla("BR", tipo, "70cm","70cm","50cm");
            }
            return NuevoMueble;
        }
        #region metodos que no se  implementan en esta fabrica
        public IMueble getSilla(string tipo)
        {
            throw new NotImplementedException();
        }

        public IMueble getSofa(string tipo)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

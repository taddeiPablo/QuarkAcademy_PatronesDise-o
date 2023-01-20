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
                NuevoMueble = new Mesilla("", tipo, "", "", "");
            }
            if (tipo == "victoriano")
            {
                NuevoMueble = new Mesilla("",tipo,"","","");
            }
            if (tipo == "moderno")
            {
                NuevoMueble = new Mesilla("", tipo, "","","");
            }
            return NuevoMueble;
        }

        public IMueble getSilla(string tipo)
        {
            throw new NotImplementedException();
        }

        public IMueble getSofa(string tipo)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica_mueble_Library.Interface;
using Fabrica_mueble_Library.Muebles;

namespace Fabrica_mueble_Library.Fabricas
{
    public class SofaFactory : IAbstractFactory
    {
        private IMueble NuevoMueble;

        public IMueble getSofa(string tipo)
        {
            if (tipo == "Art Deco")
            {
                NuevoMueble = new Sofa("", tipo, "", "", "");
            }
            if (tipo == "victoriano")
            {
                NuevoMueble = new Sofa("", tipo, "", "", "");
            }
            if (tipo == "moderno")
            {
                NuevoMueble = new Sofa("", tipo, "","","");
            }
            return NuevoMueble;
        }

        public IMueble getSilla(string tipo)
        {
            throw new NotImplementedException();
        }

        public IMueble getMesilla(string tipo)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fabrica_mueble_Library.Interface;
using Fabrica_mueble_Library.Fabricas;

namespace Fabrica_mueble_Library.Fabricas
{
    public class FabricaDeMuebles
    {
        private IAbstractFactory absFactory;
        public IAbstractFactory getFactory(string factory)
        {
            if (factory == "silla")
            {
                absFactory = SillaFactory.getInstance();
            }
            if (factory == "sofa")
            {
                absFactory = SofaFactory.GetInstance();
            }
            if (factory == "mesilla")
            {
                absFactory = MesillaFactory.getInstance();
            }

            return absFactory;
        }
    }
}

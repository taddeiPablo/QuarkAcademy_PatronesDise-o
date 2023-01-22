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
        private static FabricaDeMuebles _instance;
        private IAbstractFactory absFactory;

        public static FabricaDeMuebles getInstance()
        {
            if (_instance == null)
            {
                _instance = new FabricaDeMuebles();
            }
            return _instance;
        }

        public IAbstractFactory getFactory(string factory)
        {
            if (factory == "silla")
            {
                absFactory = new SillaFactory();
            }
            if (factory == "sofa")
            {
                absFactory = new SofaFactory();
            }
            if (factory == "mesilla")
            {
                absFactory = new MesillaFactory();
            }

            return absFactory;
        }

        public override string ToString()
        {
            return "Items";
        }


    }
}

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
        private static SofaFactory _instance;
        private IMueble NuevoMueble;

        private SofaFactory() { }

        public static SofaFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SofaFactory();
            }
            return _instance;
        }

        public IMueble getSofa(string tipo)
        {
            if (tipo == "Art Deco")
            {
                NuevoMueble = new Sofa("Arg", tipo, "80cm", "90cm", "30cm");
            }
            else if (tipo == "victoriana")
            {
                NuevoMueble = new Sofa("Antiguo", tipo, "80cm", "90cm", "30cm");
            }
            else if (string.Equals(tipo, "Moderna"))
            {
                NuevoMueble = new Sofa("Arte", tipo, "70cm","80cm","40cm");
            }
            return NuevoMueble;
        }

        #region metodos que no se implementan en esta fabrica
        public IMueble getSilla(string tipo)
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

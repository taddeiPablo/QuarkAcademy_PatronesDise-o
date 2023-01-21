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
        //private string directory = @"QuarkAcademy_PatronesDise-o\QuarkAcademy_Patrones_Implementaciones\Fabrica_mueble_Library\images\";

        public IMueble getSilla(string tipo)
        {
            if (tipo == "Art Deco")
            {
                NuevoMueble = new Silla("Art", tipo, "50cm", "50cm", "30cm", "");
            }
            if (tipo == "victoriana")
            {
                NuevoMueble = new Silla("Art",tipo,"60cm","60cm","40cm","");
            }
            if (tipo == "moderna")
            {
                NuevoMueble = new Silla("Art",tipo,"40cm","50cm","35cm","");
            }
            return NuevoMueble;
        }

        public IMueble getSofa(string tipo)
        {
            throw new NotImplementedException();
        }
        public IMueble getMesilla(string tipo)
        {
            throw new NotImplementedException();
        }
    }
}

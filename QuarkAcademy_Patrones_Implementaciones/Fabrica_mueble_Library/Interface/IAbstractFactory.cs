using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica_mueble_Library.Muebles;

namespace Fabrica_mueble_Library.Interface
{
    public interface IAbstractFactory
    {
        IMueble getSilla(string tipo);
        IMueble getSofa(string tipo);
        IMueble getMesilla(string tipo);
    }
}

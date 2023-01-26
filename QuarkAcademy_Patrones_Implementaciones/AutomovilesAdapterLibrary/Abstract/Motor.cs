using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomovilesAdapterLibrary.Abstract
{
    public abstract class Motor
    {
        public abstract void acelerar();
        public abstract void apagar();
        public abstract void arrancar();
        public abstract void cargarCombustible();
    }
}

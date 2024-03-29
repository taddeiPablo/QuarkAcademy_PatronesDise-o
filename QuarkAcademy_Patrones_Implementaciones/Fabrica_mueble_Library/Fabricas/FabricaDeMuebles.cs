﻿using System;
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
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.ObserverLibrary
{
    public abstract class Observador
    {
        protected Subject sujeto;
        public abstract void actualizar();
    }
}

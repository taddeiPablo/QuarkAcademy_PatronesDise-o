﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutomovilesAdapterLibrary.Entities;
using AutomovilesAdapterLibrary.Adapter;

namespace AutomovilesAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorDiesel mdiesel = new MotorDiesel();
            MotorNaftero mnaftero = new MotorNaftero();
            MotorElectricoAdapter mElectricoAdapter = new MotorElectricoAdapter();

            Console.WriteLine("motor diesel en funcionamiento");
            mdiesel.arrancar();
            mdiesel.acelerar();
            mdiesel.apagar();
            mdiesel.cargarCombustible();
            Console.WriteLine("motor naftero en funcionamiento");
            mnaftero.arrancar();
            mnaftero.acelerar();
            mnaftero.apagar();
            mnaftero.cargarCombustible();
            Console.WriteLine("motor electrico en funcionamiento utilizando la clase adapter");
            mElectricoAdapter.arrancar();
            mElectricoAdapter.acelerar();
            mElectricoAdapter.apagar();
            mElectricoAdapter.cargarCombustible();
            Console.ReadLine();
        }
    }
}

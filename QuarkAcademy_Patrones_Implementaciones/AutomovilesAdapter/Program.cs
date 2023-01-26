using System;
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


        }
    }
}

using AutomovilesAdapterLibrary.Abstract;
using AutomovilesAdapterLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomovilesAdapterLibrary.Adapter
{
    public class MotorElectricoAdapter : Motor
    {
        private MotorElectrico motorElectrico;

        public MotorElectricoAdapter()
        {
            this.motorElectrico = new MotorElectrico();
        }

        public override void acelerar()
        {
            motorElectrico.Mover();
        }

        public override void apagar()
        {
            motorElectrico.desactivar();
        }

        public override void arrancar()
        {
            motorElectrico.conectar();
            motorElectrico.Activar();
        }

        public override void cargarCombustible()
        {

            motorElectrico.enchufar();
        }
    }
}

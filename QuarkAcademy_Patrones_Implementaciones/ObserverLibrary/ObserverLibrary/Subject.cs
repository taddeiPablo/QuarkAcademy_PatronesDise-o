using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.ObserverLibrary
{
    public class Subject
    {
        private List<Observador> ObservadoresList;
        private double estado;

        public Subject()
        {
            ObservadoresList = new List<Observador>();
        }

        public double Estado { 
            get => estado;
            set
            {
                this.estado = value;
                notificarTodosObservadores();
            }
        }

        public void agregar(Observador observer)
        {
            ObservadoresList.Add(observer);
        }

        public void notificarTodosObservadores()
        {
            foreach (Observador ob in ObservadoresList)
            {
                ob.actualizar();
            }
        }
    }
}

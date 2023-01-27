using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MementoCoreLibrary;

namespace AppMemento
{
    class Program
    {
        static CareTaker caretaker = new CareTaker();
        static void Main(string[] args)
        {
            var p = new Persona();
            p.Nombre = "Pepe";


            caretaker.add(p.saveToMemento());

            p.Nombre = "Pepe1";
            caretaker.add(p.saveToMemento());


            p.Nombre = "Pepe2";
            caretaker.add(p.saveToMemento());


            Memento m1 = caretaker.GetMemento(0);
            Console.WriteLine("Viendo memento 1: " + m1.Estado);
            Console.WriteLine("Viendo memento 2: " + caretaker.GetMemento(1).Estado);
            Console.WriteLine("Viendo memento 3: " + caretaker.GetMemento(2).Estado);


            p.restoreToMemento(m1);

            p.restoreToMemento(caretaker.GetMemento(1));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapeDecoratorLibrary;
using ShapeDecoratorLibrary.figuras;

namespace DecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("sexto ejemplo de patron ( DECORATOR )");
            Circle nuevoCirculo = new Circle();
            Console.WriteLine("color del circulo al comienzo");
            nuevoCirculo.draw();
            RedShapeDecorator rsDecorator = new RedShapeDecorator(nuevoCirculo);
            Console.WriteLine("aqui aplicando nuevo color en nuestro circulo");
            rsDecorator.setNewColor("ROJO");
            Console.WriteLine("aqui color cambiado de nuestro circulo");
            rsDecorator.draw();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Cube nuevoCube = new Cube();
            Console.WriteLine("color del cubo la comienzo");
            nuevoCube.draw();
            BlueShapeDecorator bsDecorator = new BlueShapeDecorator(nuevoCube);
            Console.WriteLine("aqui aplicando nuevo color en nuestro cubo");
            bsDecorator.setNewColor("AZUL");
            Console.WriteLine("aqui color cambiado de nuestro cubo");
            bsDecorator.draw();
            Console.ReadLine();
        }
    }
}

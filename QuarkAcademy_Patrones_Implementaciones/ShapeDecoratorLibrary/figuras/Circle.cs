using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapeDecoratorLibrary.Interface;

namespace ShapeDecoratorLibrary.figuras
{
    public class Circle : IShape
    {
        public string color;

        public Circle()
        {
            color = "AZUL";
        }

        public void draw()
        {
            Console.WriteLine("COLOR ACTUAL : " + color);
        }
    }
}

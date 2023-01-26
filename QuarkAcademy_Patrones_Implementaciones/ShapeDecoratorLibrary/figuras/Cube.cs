using ShapeDecoratorLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDecoratorLibrary.figuras
{
    public class Cube : IShape
    {
        public string color;

        public Cube()
        {
            color = "ROJO";
        }

        public void draw()
        {
            Console.WriteLine("COLOR ACTUAL : " + color);
        }
    }
}

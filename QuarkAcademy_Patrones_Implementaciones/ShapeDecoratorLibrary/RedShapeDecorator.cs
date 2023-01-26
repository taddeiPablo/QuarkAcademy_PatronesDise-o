using ShapeDecoratorLibrary.Abstract;
using ShapeDecoratorLibrary.figuras;
using ShapeDecoratorLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDecoratorLibrary
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape figura) : base(figura)
        {
        }

        public void setNewColor(string nuevoColor)
        {
            if (this.shape.GetType() == typeof(Circle))
            {
                // casting
                Circle circle = (Circle)this.shape;
                circle.color = nuevoColor;
                this.shape = circle;
            }
            else if (this.shape.GetType() == typeof(Cube))
            {
                Cube cube = (Cube)this.shape;
                cube.color = nuevoColor;
                this.shape = cube;
            }
        }
    }
}

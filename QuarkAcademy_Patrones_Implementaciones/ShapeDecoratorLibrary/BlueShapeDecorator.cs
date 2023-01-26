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
    public class BlueShapeDecorator : ShapeDecorator
    {
        public BlueShapeDecorator(IShape figura) : base(figura)
        {
        }
        public void setNewColor(string nuevocolor)
        {
            if (this.shape.GetType() == typeof(Circle))
            {
                Circle circle = (Circle)this.shape;
                circle.color = nuevocolor;
                this.shape = circle;
            }else if(this.shape.GetType() == typeof(Cube))
            {
                Cube cube = (Cube)this.shape;
                cube.color = nuevocolor;
                this.shape = cube;
            }
        }
    }
}

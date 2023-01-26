using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapeDecoratorLibrary.Interface;

namespace ShapeDecoratorLibrary.Abstract
{
    public abstract class ShapeDecorator : IShape
    {
        // aqui declaro una variable de tipo IShape
        protected IShape shape;

        // constructor que recibe un tipo IShape
        public ShapeDecorator(IShape figura)
        {
            this.shape = figura;
        }

        // implemento el metodo que viene de la interface IShape
        public void draw()
        {
            this.shape.draw();
        }
    }
}

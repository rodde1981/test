using System;
using Shapes;

namespace Presenter.Tests
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }


        public override double Area()
        {
            return Math.PI*Math.Pow(this.radius,2);
        }
    }
}
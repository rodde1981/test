using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace Presenter.Tests
{
    public class ShapeCalculator
    {
  

        public int CalculateArea(Rectangle rectangle)
        {
            return rectangle.width*rectangle.height;
        }
    }
}
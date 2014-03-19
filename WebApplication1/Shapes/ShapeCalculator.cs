namespace Shapes
{
    public class ShapeCalculator
    {
  

        public int CalculateArea(Rectangle rectangle)
        {
            return rectangle.width*rectangle.height;
        }

        public int CalculateArea(Square square)
        {
            return square.width * square.width;
        }
    }
}
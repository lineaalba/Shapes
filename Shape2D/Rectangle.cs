
namespace Examination_2
{
    /// <summary>
    /// The Rectangle class.
    /// </summary>
    class Rectangle : Shape2D
    {
        /// <summary>
        /// Overrides, calculates and returns the area of an rectangle.
        /// </summary>
        public override double Area
        {
            get 
            { 
                return Length * Width; 
            }
        }

        /// <summary>
        /// Overrides, calculates and returns the perimeter of an rectangle.
        /// </summary>
        public override double Perimeter
        {
            get 
            { 
                return 2 * Length + 2 * Width; 
            }
        }
        
        /// <summary>
        /// Invokes the base class constructor to ensure that the length and width of the new object are set.
        /// </summary>
        public Rectangle(double length, double width) : base(ShapeType.Rectangle, length, width)
        {
            Length = length;
            Width = width;
        }
    }
}
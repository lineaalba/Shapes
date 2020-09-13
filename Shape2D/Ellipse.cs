using System;

namespace Examination_2
{
    /// <summary>
    /// The Ellipse class.
    /// </summary>
    class Ellipse : Shape2D
    {
        /// <summary>
        /// Overrides, calculates and returns the area of an ellipse.
        /// </summary>
        public override double Area
        {
            get 
            { 
                double x = Length / 2;
                double y = Width / 2;
                return Math.PI * x * y;
            }
        }

        /// <summary>
        /// Overrides, calculates and returns the perimeter of an ellipse.
        /// </summary>
        public override double Perimeter
        {
            get 
            { 
                double x = Length / 2;
                double y = Width / 2;
                return Math.PI * Math.Sqrt(2 * Math.Pow(x, 2) + 2 * Math.Pow(y, 2)); 
            }
        }

        /// <summary>
        /// Constructor to use if shape is a circle.
        /// </summary>
        public Ellipse(double diameter) : base(ShapeType.Ellipse, diameter, diameter)
        {
            /// Empty.
        }

        /// <summary>
        ///  Invokes the base class constructor to ensure that the length and width of the new object are set.
        /// </summary>
        public Ellipse(double hdiameter, double vdiameter) : base(ShapeType.Ellipse, hdiameter, vdiameter)
        {
            Length = hdiameter;
            Width = vdiameter;
        }
    }
}
using System;

namespace Examination_2
{
    /// <summary>
    /// The 2D shape type class.
    /// </summary>
    public abstract class Shape2D : Shape
    {
        private double _length;
        private double _width;

        /// <summary>
        /// Represents the area of the shape.
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        /// Encapsulates the _length field and validates the value.
        /// </summary>
        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _length = value;
            }
        }

        /// <summary>
        /// Represents the perimeter of a shape.
        /// </summary>
        public abstract double Perimeter { get; }

        /// <summary>
        /// Encapsulates the _width field and validates the value.
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _width = value;
            }
        }

        /// <summary>
        /// Constructor makes sure that the variables, through the properties, assigns the values of the parameters of the constructor.
        /// </summary>
        protected Shape2D(ShapeType shapeType, double length, double width) : base(shapeType)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// If ToString is called without any parameters the method should return ToString("G").
        /// </summary>
        public override string ToString()
        {
            return ToString("G");
        }

        /// <summary>
        /// Overrides the ToString method in Shape.cs and decides how the text based application
        /// is presented.
        /// </summary>
        public override string ToString(string format)
        {
            double area = Math.Round(Area, 1);
            double perimeter = Math.Round(Perimeter, 1);

            if (format == null || format == "" || format == "G")
            {
                return $"{ShapeType}\n Length: {Length}\n Width: {Width}\n Perimeter: {perimeter}\n Area: {area}";
            } 
            else if (format == "R")
            {
                return $"| {ShapeType, -9} | {Length, -6} | {Width, -5} | {perimeter, -9} | {area, -6} |";
            }
            throw new FormatException();
        }
    }
}
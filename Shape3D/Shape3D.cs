using System;

namespace Examination_2
{
    /// <summary>
    /// The 3D shape type class.
    /// </summary>
    public abstract class Shape3D : Shape
    {
        /// <summary>
        /// Represents the base shape of a 3d shape (ellipse or rectangle).
        /// </summary>
        protected Shape2D _baseShape;

        /// <summary>
        /// represents the height of a shape.
        /// </summary>
        private double _height;

        /// <summary>
        /// Encapsulates the _height field and validates the value.
        /// </summary>
        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _height = value;
            }
        }

        /// <summary>
        /// Auto implemented property that encapsulates length.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Calculates and returns the mantel area with the perimeter from Shape2D.cs.
        /// </summary>
        public virtual double MantelArea
        {
            get
            {
                return _baseShape.Perimeter * Height;
            }
        }

        /// <summary>
        /// Calculates and returns the total surface area with the area from Shape2D.cs.
        /// </summary>
        public virtual double TotalSurfaceArea
        {
            get
            {
                return (MantelArea + 2) * _baseShape.Area;
            }
        }

        /// <summary>
        /// Auto implemented property that encapsulates width.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Calculates and returns the volume with the area from Shape2D.cs.
        /// </summary>
        public virtual double Volume
        {
            get
            {
                return _baseShape.Area * Height;
            }
        }

        /// <summary>
        /// Constructor makes sure that the variables, through the properties, assigns the values of the parameters of the constructor.
        /// </summary>
        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height) : base(shapeType)
        {
            _baseShape = baseShape;
            Height = height;
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
            double ma = Math.Round(MantelArea, 1);
            double tsa = Math.Round(TotalSurfaceArea, 1);
            double vol = Math.Round(Volume, 1);

            if (format == null || format == "" || format == "G")
            {
                return $"{ShapeType}\n Length: {Length}\n Width: {Width}\n Height: {Height}\n Mantelarea: {ma}\n Total Surface Area: {tsa}\n Volume: {vol}";
            } 
            else if (format == "R")
            {
                return $"| {ShapeType, -9} | {Length, -6} | {Width, -5} | {Height, -6} | {ma, -11} | {tsa, -18} | {vol, -7} |";
            }
            throw new FormatException();
        }
    }
}
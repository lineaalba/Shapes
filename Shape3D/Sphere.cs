
namespace Examination_2
{
    /// <summary>
    /// The Sphere class.
    /// </summary>
    class Sphere : Shape3D
    {
        /// <summary>
        /// Encapsulates Length and Width from base class.
        /// </summary>
        public double Diameter
        {
            get 
            {
                return Length; 
            }
            set 
            { 
                Length = value; Width = value; 
            }
        }

        /// <summary>
        /// Overrides, calculates and returns the mantel area of an sphere with the area from Shape2D.cs.
        /// </summary>
        public override double MantelArea
        {
            get 
            { 
                return _baseShape.Area * 4; 
            }
        }

        /// <summary>
        /// Overrides and returns the total surface area of a sphere,
        /// that is the same as the mantel area of a sphere.
        /// </summary>
        public override double TotalSurfaceArea
        {
            get 
            { 
                return MantelArea; 
            }
        }

        /// <summary>
        /// Overrides, calculates and returns the volume of a sphere with the area from Shape2D.cs.
        /// </summary>
        public override double Volume
        {
            get 
            { 
                return (4 * _baseShape.Area * (Diameter / 2) / 3); 
            }
        }

        /// <summary>
        /// Invokes the base class constructor to ensure that the diameter of the new object is set.
        /// </summary>
        public Sphere(double diameter) : base(ShapeType.Sphere, new Ellipse(diameter), diameter)
        {
            Diameter = diameter;
        }
    }
}
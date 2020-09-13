
namespace Examination_2
{
    /// <summary>
    /// The Cylinder class.
    /// </summary>
    class Cylinder : Shape3D
    {
        /// <summary>
        /// Invokes the base class constructor to ensure that the horizontal and vertical diameter of the new object is set.
        /// </summary>
        public Cylinder(double hdiameter, double vdiameter, double height) : base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        {
            Length = hdiameter;
            Width = vdiameter;
            Height = height;
        }
    }
}
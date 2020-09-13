
namespace Examination_2
{
    /// <summary>
    /// The Cuboid class.
    /// </summary>
    class Cuboid : Shape3D
    {
        /// <summary>
        /// Invokes the base class constructor to ensure that the length, width and height of the new object are set.
        /// </summary>
        public Cuboid(double length, double width, double height) : base(ShapeType.Cuboid, new Rectangle(length, width), height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
    }
}
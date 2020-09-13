namespace Examination_2
{
    public abstract class Shape
    {
    /// <summary>
    /// Returns true if shape type is 3D.
    /// </summary>
     public bool Is3D
     {
         get
         {
            if (ShapeType == ShapeType.Cuboid || ShapeType == ShapeType.Cylinder || ShapeType == ShapeType.Sphere)
            {
                return true;
            }
            else
            {
                return false;
            }
         }
     }

    /// <summary>
    /// autoimplemented property defines what type of shape it is.
    /// </summary>
     public ShapeType ShapeType{get; private set;}

    /// <summary>
    /// Constructor makes sure the class initiates with the value of the parameter.
    /// </summary>
     protected Shape(ShapeType shapeType)
     {
         ShapeType = shapeType;
     }
    /// <summary>
    /// Returns a text based version of the class.
    /// </summary>
     public abstract string ToString(string format);  
    }
}
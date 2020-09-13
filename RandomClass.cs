using System;

namespace Examination_2
{
    /// <summary>
    /// Returns random number of shapes in 2D or 3D.
    /// </summary>
    public class RandomClass
    {
        /// <summary>
        /// Creates a new instance of random object.
        /// </summary>
        Random random = new Random();

        /// <summary>
        /// Returns different numbers as parameters depending on if the shape is 3D or 2D.
        /// </summary>
        public int RandomShape(bool is3D)
        {
            if (is3D)
            {
               return RandomNumberShapes(2, 4);
            }
            else
            {
                return RandomNumberShapes(0, 1);
            }
        }

        /// <summary>
        /// Get random number of shapes.
        /// </summary>
        public int RandomNumberShapes(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}
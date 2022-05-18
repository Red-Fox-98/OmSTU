using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Vector
    {
        public float x;
        public float y;

        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector operator /(Vector vector, float divider)
        {
            vector.x /= divider;
            vector.y /= divider;
            return vector;
        }

        public static Vector operator +(Vector vector1, Vector vector2)
        {
            vector1.x += vector2.x;
            vector1.y += vector2.y;
            return vector1;
        }

        public static Vector operator *(Vector vector, float multiplier)
        {
            vector.x *= multiplier;
            vector.y *= multiplier;
            return vector;
        }
    }
}
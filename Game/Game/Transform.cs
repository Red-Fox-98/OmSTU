using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Transform
    {
        public Vector position;
        public Transform(float x, float y)
        {
            position = new Vector(x, y);
        }
    }
}
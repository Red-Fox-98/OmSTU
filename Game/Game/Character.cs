using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Character
    {
        public Avatar avatar;
        public Vector v;

        public Character(int x, int y, Avatar avatar)
        {
            v = new Vector(x, y);
            this.avatar = avatar;
        }

        public void Move(int x_, int y_)
        {
            v.x += x_;
            v.y += y_;
        }

        public void Update()
        {
            avatar.Draw(v.x, v.y);
        }
    }
}
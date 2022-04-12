using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Character
    {
        public int x;
        public int y;

        public Avatar avatar;

        public Character(int x, int y, Avatar avatar)
        {
            this.x = x;
            this.y = y;
            this.avatar = avatar;
        }

        public void Move(int x_, int y_)
        {
            x += x_;
            y += y_;
        }

        public void Update()
        {
            avatar.Draw(x, y);
        }
    }
}
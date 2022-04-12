using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Avatar
    {
        public string[,] avatar;

        public Avatar(string[,] avatar) 
        {
            this.avatar = avatar;
        }

        public void Draw(int x, int y)
        {
            for (int i = 0; i < this.avatar.GetLength(0); i++)
            {
                for (int j = 0; j < this.avatar.GetLength(1); j++)
                {
                    Console.SetCursorPosition(x + i, y + j);
                    Console.Write(this.avatar[i, j]);
                }
            }
        }
    }
}
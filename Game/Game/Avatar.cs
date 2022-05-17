using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Avatar
    {
        public char[,] avatar;
        public Buffer buffer;

        public Avatar(char[,] avatar, Buffer buffer) 
        {
            this.avatar = avatar;
            this.buffer = buffer;
        }

        public void Draw(int x, int y)
        {
            buffer.Push(avatar, x, y);
            //for (int i = 0; i < avatar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < avatar.GetLength(1); j++)
            //    {
            //        Console.SetCursorPosition(x + j, y + i);
            //        Console.Write(avatar[i, j]);
            //    }
            //}
        }
    }
}
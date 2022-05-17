using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Physics
    {
        public string[,] avatar;

        public Physics(string[,] avatar)
        {
            this.avatar = avatar;
        }

        public void PhysicsOfMovement(int x, int y)
        {
            int i = 1;
            for (int j = 0; j < avatar.GetLength(1); j++)
            {
                Console.SetCursorPosition(x + j, y + i);
                
                y += 1;
            }
        }
    }
}
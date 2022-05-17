using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 45);
            Console.SetBufferSize(150, 45);

            Game game = new Game();
            game.Start();

            while (true)
            {
                game.Update();
            }
        }
    }
}
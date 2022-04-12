using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(190, 40);
            Console.SetBufferSize(190, 40);
            
            Game game = new Game();
            game.Start();

            while (true)
            {
                game.Update();
            }
        }
    }
}
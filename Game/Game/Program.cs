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
            Console.SetWindowSize(121, 41);
            Console.SetBufferSize(121, 41);

            Game game = new Game();
            game.Start();

            while (true)
            {
                game.Update();
            }
        }
    }
}
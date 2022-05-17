using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Game
    {
        public PlayerController playerController;
        public Character player;
        public Buffer buffer;
        public Map map;

        public Game()
        {

        }

        public void Start()
        {
            char[,] playerPicture =
            {
                {' ', '*', ' ' },
                {'-', '#', '-' },
                {'#', ' ', '#' }
                //{"#", "#", "#" },
                //{"*", "*", "*" },
                //{" ", "*", " " },
                //{"*", "#", "*" },
                //{" ", "#", " " },
                //{"#", " ", "#" }
            };

            buffer = new Buffer(40, 120, '!');
            Avatar avatar = new Avatar(playerPicture, buffer);
            //this.map = new Map();
            this.player = new Character(0, 0, avatar);
            this.playerController = new PlayerController(player);
        }

        public void Update()
        {
            buffer.Clear();

            List<ConsoleKeyInfo> keys = new List<ConsoleKeyInfo>();
            if (Console.KeyAvailable)
            {
                keys.Add(Console.ReadKey());
            }

            playerController.Update(keys);
            this.player.Update();

            buffer.Draw();
            Thread.Sleep(100);
            //map.DrawMap();
        }
    }
}
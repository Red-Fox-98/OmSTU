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
        public List<Collider> collidersList;
        public Floor floor;

        public Game()
        {

        }

        public void Start()
        {
            collidersList = new List<Collider>();
            
            char[,] playerPicture =
            {
                {' ', '*', ' ' },
                {'-', '#', '-' },
                {'/', ' ', '\\' }
            };

            char[,] floorPicture =
            {
                {'=', '=', '=' },
                {'=', '=', '=' },
                {'=', '=', '=' }
            };

            
            buffer = new Buffer(40, 120, '!');
            Avatar playerAvatar = new Avatar(playerPicture, buffer);
            this.player = new Character(0, 0, playerAvatar, collidersList);
            this.playerController = new PlayerController(player);

            Avatar floorAvatar = new Avatar(floorPicture, buffer);
            this.floor = new Floor(0, 25, floorAvatar, collidersList);


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
            floor.Update();
            this.player.Update();

            buffer.Draw();
            Thread.Sleep(25);
            //map.DrawMap();
        }

    }
}
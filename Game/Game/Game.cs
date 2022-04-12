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

        public Game()
        {

        }

        public void Start()
        {

            string[,] playerPicture =
            {
                {"s", "s" },
                {"s", "s" }
            };

            Avatar avatar = new Avatar(playerPicture);
            this.player = new Character(30, 30, avatar);
            this.playerController = new PlayerController(player);
        }

        public void Update()
        {
            List<ConsoleKeyInfo> keys = new List<ConsoleKeyInfo>();
            if (Console.KeyAvailable)
            {
                keys.Add(Console.ReadKey());
            }
            
            playerController.Update(keys);
            this.player.Update();
        }
    }
}
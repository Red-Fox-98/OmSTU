﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class PlayerController
    {
        public Character player;
        public PlayerController(Character player)
        {
            this.player = player;
        }

        public void Update(List<ConsoleKeyInfo> keys)
        {
            if (keys.Count == 0)
            {
                return;
            }
            else
            {
                Console.Clear();
                if (keys[0].Key == ConsoleKey.RightArrow)
                {
                    moveToRight();
                }
                if (keys[0].Key == ConsoleKey.LeftArrow)
                {
                    moveToLeft();
                }
            }
        }

        public void moveToRight()
        {
            player.Move(1, 0);
        }

        public void moveToLeft()
        {
            player.Move(-1, 0);
        }
    }
}
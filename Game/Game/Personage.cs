using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Personage
    {
        public bool bigIncrease;
        public Personage(bool bigIncrease)
        {
            this.bigIncrease = bigIncrease;

            if (bigIncrease == true)
            {
                bigPersonageDrawing();
            }
            else
            {
                personageDrawing();
            }
        }

        public void personageDrawing()
        {
            char[,] personage = new char[7, 7]
           {
                {' ', ' ', '#', '#', '#', ' ', ' '},
                {' ', ' ', '*', '*', '*', ' ', ' '},
                {' ', ' ', ' ', '*', ' ', ' ', ' '},
                {' ', '#', '#', '*', '#', '#', ' '},
                {'*', ' ', '#', '#', '#', ' ', '*'},
                {' ', ' ', '#', ' ', '#', ' ', ' '},
                {' ', '#', '#', ' ', '#', '#', ' '}
           };

            for (int i = 0; i < personage.GetLength(0); i++)
            {
                for (int j = 0; j < personage.GetLength(1); j++)
                {
                    Point p = new Point(3 + j, 3 + i, personage[i, j]);
                    p.Draw();
                }
            }
        }

        public void bigPersonageDrawing()
        {
            char[,] bigPersonage = new char[9, 7]
            {
                {' ', ' ', '#', '#', '#', ' ', ' '},
                {' ', ' ', '*', '*', '*', ' ', ' '},
                {' ', ' ', '*', '*', '*', ' ', ' '},
                {' ', ' ', ' ', '*', ' ', ' ', ' '},
                {' ', '#', '#', '*', '#', '#', ' '},
                {'*', ' ', '#', '#', '#', ' ', '*'},
                {' ', ' ', '#', '#', '#', ' ', ' '},
                {' ', ' ', '#', ' ', '#', ' ', ' '},
                {' ', '#', '#', ' ', '#', '#', ' '}
            };

            for (int i = 0; i < bigPersonage.GetLength(0); i++)
            {
                for (int j = 0; j < bigPersonage.GetLength(1); j++)
                {
                    Point p = new Point(16 + j, 1 + i, bigPersonage[i, j]);
                    p.Draw();
                }
            }
        }
    }
}
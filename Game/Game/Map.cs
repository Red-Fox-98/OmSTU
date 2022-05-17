using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Map
    {
        public char[,] arrayMap;
        public Map()
        {
            string str = File.ReadAllText(@"E:\Github\OmSTU\Game\Game\map.txt");

            char[] array = str.ToCharArray();
            this.arrayMap = new char[40, 120];
            int counter = 0;

            for (int y = 0; y < arrayMap.GetLength(0); y++)
            {
                for (int x = 0; x < arrayMap.GetLength(1);)
                {
                    if (array[counter] != '\r' && array[counter] != '\n')
                    {
                        arrayMap[y, x] = array[counter]; x++;
                    }
                    counter++;
                }
            }
        }

        public void DrawMap()
        {
            for (int y = 0; y < arrayMap.GetLength(0); y++)
            {
                for (int x = 0; x < arrayMap.GetLength(1); x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(arrayMap[y, x]);
                }
            }
        }
    }
}
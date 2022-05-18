using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Buffer
    {
        int height;
        int width;
        char[,] buffer;
        char foregroundSymbol;

        public Buffer(int height, int width, char foregroundSymbol = ' ')
        {
            if(height < 0 || width < 0)
            {
                throw new ArgumentException("Error! Wrong buffer size");
            }
            this.height = height;
            this.width = width;
            this.foregroundSymbol = foregroundSymbol;
            this.buffer = new char[height, width];
        }

        public void Draw()
        {
            Console.Clear();
            for (int y = 0; y < height; y++)
            {
                string row = "";
                for (int x = 0; x < width; x++)
                {
                    row += buffer[y, x];
                }
                Console.WriteLine(row);
            }
        }

        public void Push(char[,] image, int x, int y)
        {
            for (int j = 0; j < image.GetLength(0); j++)
            {
                for (int i = 0; i < image.GetLength(1); i++)
                {
                    if (x + i < width && y + j < height && x + i >= 0 && y + j >= 0)
                    {
                        buffer[y + j, x + i] = image[j, i];
                    }
                }
            }
        }

        public void Clear()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    buffer[y, x] = foregroundSymbol;
                }
            }
        }
    }
}
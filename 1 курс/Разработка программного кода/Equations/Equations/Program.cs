using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equations
{
    internal class Program
    {
        public static List<double> listRoots = new List<double>();
        public static double x;
        public static double y;

        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            //////////////////////////////////////////////////////////
            calculate_roots(a, b, c);
            Console.Write("Корни уравнения: ");
            if (listRoots.Count > 1)
            {
                Console.Write("\nx1= " + listRoots[0] + "\t");
                Console.Write("x1= " + listRoots[1] + "\n");
            }
            if (listRoots.Count == 1)
            {
                Console.Write("\nx1= " + listRoots[0] + "\n");
            }
            if (listRoots.Count == 0)
            {
                Console.Write("корней нет\n");
            }
            //////////////////////////////////////////////////////////
            calculate_extremum(a, b, c);
            if (a != 0)
            {
                if (a > 0)
                {
                    Console.Write("Убывает (" + -double.PositiveInfinity + "," + x + ") , " + "Возрастает (" + x + "," + double.PositiveInfinity + ")\n");
                }
                if (a < 0)
                {
                    Console.Write("Возрастает (" + -double.PositiveInfinity + "," + x + ") , " + "Убывает (" + x + "," + double.PositiveInfinity + ")\n");
                }
            }
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////");
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                a = 1;
                b = random.Next(-5, 5);
                c = random.Next(-2, 2);
                calculate_roots(a, b, c);
            }

            Console.Write("Максимальное число = " + listRoots.Max());
            Console.Write("\nМинимальное число = " + listRoots.Min() + "\n");
        }
        private static void calculate_roots(double a, double b, double c)
        {
            double dis;
            if (a != 0)
            {
                dis = Math.Pow(b, 2) - (4 * a * c);
                if (dis > 0)
                {
                    double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                    x1 = Math.Round(x1, 2);
                    listRoots.Add(x1);
                    double x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                    x2 = Math.Round(x2, 2);
                    listRoots.Add(x2);
                }
                if (dis == 0)
                {
                    double x1 = (-b) / (2 * a);
                    x1 = Math.Round(x1, 2);
                    listRoots.Add(x1);
                }
            }
        }
        private static void calculate_extremum(double a, double b, double c)
        {
            x = (-b) / (2 * a);
            y = a * Math.Pow(x, 2) + (b * x) + c;
        }
    }
}
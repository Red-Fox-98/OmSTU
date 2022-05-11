using System;

namespace Lab1
{
    class Program
    {
        public bool result = true;
        static void Main(string[] args)
        {
            //Ввод значений N и c
            Console.Write("Введите значение N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите значение c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //Проверка значений
            Console.WriteLine("Проверка значений: ");
            Console.Write("c простое число - ");
            Console.WriteLine(CheckingForAPrimeNumber(c)); ;
            Console.Write("N и c взаимно простые числа - ");
            Console.WriteLine(CheckingForCoprimeNumbers(N, c));
            Console.WriteLine();
            
            if (CheckingForAPrimeNumber(c) == true & CheckingForCoprimeNumbers(N, c) == true)
            {
                //вычисление всех нетривиальных делителей числа N
                int quantityXn = N;
                int x = 0;
                int[] arrayOfNontrivialNumbers0 = new int[quantityXn];
                Console.WriteLine("\nВсе нетривиальные делители числа N:");
                for (int i = 1; i < N; i++)
                {
                    if (N % i == 0)
                    {
                        arrayOfNontrivialNumbers0[x] = i;
                        x++;
                        Console.Write(i + "\t");
                    }
                }
                int[] arrayOfNontrivialNumbers = new int[x];
                CreatingArray(arrayOfNontrivialNumbers0, arrayOfNontrivialNumbers);
                
                Console.WriteLine();
                Console.WriteLine("\nВсе простые числа из нетривиальных делителей числа N: ");
                int[] arrayOfPrimeNontrivialNumbers0 = new int[x];
                int p = 0;
                //поиск простых чисел среди нетривиальных делителей
                for (int i = 0; i < arrayOfNontrivialNumbers.Length; i++)
                {

                    if (CheckingNontrivialNumbers(arrayOfNontrivialNumbers[i]) != 0)
                    {
                        arrayOfPrimeNontrivialNumbers0[p] = arrayOfNontrivialNumbers[i];
                        p++;
                    }
                }
                int[] arrayOfPrimeNontrivialNumbers = new int[p];
                CreatingArray(arrayOfPrimeNontrivialNumbers0, arrayOfPrimeNontrivialNumbers);
                int counter = 0;
                int b = 0;
                //вычисление числа b
                for (int i = 0; i < arrayOfNontrivialNumbers.Length; i++)
                {
                    counter = 0;
                    for (int j = 0; j < arrayOfPrimeNontrivialNumbers.Length; j++)
                    {
                        if (arrayOfNontrivialNumbers[i] % arrayOfPrimeNontrivialNumbers[j] == 0)
                        {
                            if (arrayOfNontrivialNumbers[i] % 4 == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == arrayOfPrimeNontrivialNumbers.Length)
                        {
                            b = arrayOfNontrivialNumbers[i];
                        }
                    }
                    if (b != 0)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("\nЗначение числа b = a - 1: " + b);
                int a = b + 1;
                Console.WriteLine("\nЗначение числа а = " + a);
                //вычисление значений xn и периода T
                Console.Write("\nВведите значение x0: ");
                int x0 = int.Parse(Console.ReadLine());
                int xn = x0;
                int T = 0;
                Console.WriteLine();

                for (int i = 0; i < quantityXn + 1; i++)
                {
                    if (i == quantityXn)
                    {
                        Console.WriteLine("\n\nЭлемент x(n+1) = " + xn);
                    }
                    if (i < 100)
                    {
                        Console.Write(xn + "\t");
                    }
                    if (i < quantityXn)
                    {
                        xn = ((a * xn) + c) % N;
                        T++;
                    }
                }
                Console.WriteLine("\nКоличество элементов, T = " + T);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        //преобразование массива
        public static int[] CreatingArray(int[] array1, int[] array2)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
            }
            return array2;
        }
        //проверка на простое число среди нетривиальных делителей
        public static int CheckingNontrivialNumbers(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (number == 1)
            {
                return 0;
            }
            Console.Write(number + "\t");
            return number;
        }
        //проверка на простое число
        public static bool CheckingForAPrimeNumber(int number)
        {
            var result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    return result;
                }
            }
            return result;
        }
        //проверка на взимо простые числа
        public static bool CheckingForCoprimeNumbers(int number1, int number2)
        {
            var result = true;

            for (int i = 2; i <= number2; i++)
            {
                if (number1 % i == 0 & number2 % i == 0)
                {
                    result = false;
                    return result;
                }
            }
            return result;
        }
    }
}
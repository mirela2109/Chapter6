using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Въведете x:");
            int x = int.Parse(Console.ReadLine());
            double factN = 1;

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                x *= x;
            }
            double sum = 1 + (factN / x);

            Console.WriteLine("резултатът е {0}",sum);



        }
    }

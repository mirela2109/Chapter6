using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете N:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % (3 * 7) != 0) 
                {
                    Console.WriteLine(i);
                }
               
            }
        }
    }
}

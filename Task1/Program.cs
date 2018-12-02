using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете N:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine(i);
            }

        }
    }
}

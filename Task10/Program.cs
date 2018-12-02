using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете N:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0 || n >= 20)
            {
                Console.WriteLine("False");
            }

            for (int i = 0; i < n; i++)
            {
                int counter = i + 1;
                for (int j = 0; j < n; j++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }

        }
    }
}

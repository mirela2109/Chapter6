using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Въведете n:");
            int n = int.Parse(Console.ReadLine());
             int ch = 2 * n, z = n + 1;
            if (n<0)
            {
                Console.WriteLine("False");
            }
            for (int i = ch - 1; i > 0; i--)
            {
                ch *= i;
            }
            for (int i = z - 1; i > 0; i--)
            {
                z *= i;
            }
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            double result = ch / (z * n);
            Console.WriteLine("Резултатът е {0}", result);
        }
    }
}

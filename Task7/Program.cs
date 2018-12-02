using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Въведете K:");
            int K = int.Parse(Console.ReadLine());
            Console.Write(" Въведете N:");
            int N = int.Parse(Console.ReadLine());
            if (K >= N || K <= 1 || N <= 1 || N > 1000)
            {
                Console.WriteLine("False");
            }
            int integerM = N - K;
            for (int i = N - 1; i > 0; i--) N *= i;
            for (int i = K - 1; i > 0; i--) K *= i;
            for (int i = integerM - 1; i > 0; i--) integerM *= i;
            double result = N * K / integerM;
            Console.WriteLine("Резултатът е {0}",integerM);
        }
    }
}

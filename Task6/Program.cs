using System;

namespace Task6
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
            for (int i = N - 1; i > 0; i--)
            {
                N *= i;
            }

            for (int i = K - 1; i > 0; i--)
            {
                K *= i;
            }

            N /= K;
            Console.WriteLine("Резултатът е {0}", N);



        }
    }
}

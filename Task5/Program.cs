using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете N: ");
            double N = double.Parse(Console.ReadLine());
           
            int first = -1;
            int second = 1;
            for (int i = 0; i < N; i++)
            {
               int third = first + second;
                Console.WriteLine(third);
                first = second;
                second = third;
            }

        }
    }
}

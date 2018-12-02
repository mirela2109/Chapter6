using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете N: ");
            decimal n = Int32.Parse(Console.ReadLine());
            int zeroes = 0;

            for (int i = (int)(n - 1); i > 0; i--)
                n *= i;

            Console.Write("N! е {0} и завършва ", n);

            do
            {
                n /= 10;
                zeroes++;
            } while (n % 10 == 0);

            Console.WriteLine("с {0} нули.", zeroes);
        }
    }
}

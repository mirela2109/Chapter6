using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете първото число: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете второто число: ");
            int b = Int32.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }

            if (a == 0) Console.WriteLine(b);
            else Console.WriteLine(a);
        }
    }
}

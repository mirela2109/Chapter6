using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            int n = Int32.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Числото в двоична бройна система е: {0}", binary);
        }
    }
}

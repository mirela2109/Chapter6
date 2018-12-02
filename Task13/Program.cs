using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число от двоична бройна система: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 2), 10);
            Console.WriteLine("Числото в десетична бройна система: {0}", toDecimal);
        }
    }
}

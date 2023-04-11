using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> power = PowerNumber;
            Console.WriteLine(power(5));
        }
        public static int PowerNumber(int num)
        {
            return num * num;
        }
    }
}

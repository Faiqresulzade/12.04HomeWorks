using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> action=PowerOfNumber;
            Action<int> action1=SumOfNumbers;
            // { action, action1, action2, action3, action4 }
            List<Action<int>> actions = new List<Action<int>>() { action,action1 };
        }
        public static void PowerOfNumber(int number)
        {
            Console.WriteLine(number*number);
        }
        public static void SumOfNumbers(int num1)
        {
            Console.WriteLine(num1+2);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> func = AddNumber;
            List<int> numbers = new List<int> { 1, 2, 3, 45, 6 };
            ChangeList(numbers, func);
        }
        public static void ChangeList(List<int> numbers, Action<int> func)
        {
            foreach (var item in numbers)
            {
                func(item);
            }
        }
        public static void AddNumber(int item)
        {
            Console.WriteLine(item + 1);
        }
    }
}

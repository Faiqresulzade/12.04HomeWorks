using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> function = IsEven;
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 67, 8 };
            PrintEvenNumber(numbers, function);
        }
        public static void PrintEvenNumber(List<int> numbers, Predicate<int> function)
        {
            foreach (var item in numbers)
            {
                if (function(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static bool IsEven(int item)
        {
            return item % 2 == 0;
        }
    }
}

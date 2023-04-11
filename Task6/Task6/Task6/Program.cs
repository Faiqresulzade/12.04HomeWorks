using System;
using System.Collections.Generic;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = LenghtGreateThanSix;
            List<string> names = new List<string> { "Faig", "Samir", "Shamxal" };
            Filter(names,predicate);
        }
        public static void Filter(List<string> names, Predicate<string> predicate)
        {
            foreach (var item in names)
            {
                if (LenghtGreateThanSix(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static bool LenghtGreateThanSix(string item)
        {
            if (item.Length > 6)
            {
                return true;
            }
            return false;
        }
    }
}

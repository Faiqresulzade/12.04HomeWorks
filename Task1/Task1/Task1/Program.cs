using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> Print = PrintSomeThing;
            Print("Salam");
        }
        static void PrintSomeThing(string word)
        {
            Console.WriteLine(word);
        }
    }
}

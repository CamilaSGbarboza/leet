using System;

namespace leet
{
    class Program
    {
        private const string V = "A";

        static void Main(string[] args)
        {
           Console.WriteLine("digite:");
           string digite = Console.ReadLine();
           Console.Write($"{digite.Replace("a", "4").Replace("A", "4").Replace("e", "3").Replace("E", "3").Replace("i", "1").Replace("I", "1").Replace("l","1").Replace("L", "1").Replace("O", "0").Replace("o", "0").Replace("t", "7").Replace("t", "7").Replace("s", "5").Replace("S", "5")}");




        }
    }
}

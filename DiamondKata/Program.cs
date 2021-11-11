using System;

namespace DiamondKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character:");
            Char input = (Char)Console.Read();

            var diamondCreator = new DiamondCreator();
            var result = diamondCreator.Create(input);
            Console.WriteLine("");
            Console.WriteLine(result);
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}

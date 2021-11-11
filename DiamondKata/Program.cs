using System;

namespace DiamondKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character between A and Z:");
            int input = Console.Read();
            if (input < 'A' || input > 'Z')
            {
                Console.WriteLine("Input character must be between A and Z.");
            }
            else
            {
                var diamondCreator = new DiamondCreator();
                var result = diamondCreator.Create((char)input);
                Console.WriteLine("");
                Console.WriteLine(result);
            }
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}

using System;

namespace Coding_Exercise.Facade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var magicSquareGenerator = new MagicSquareGenerator();
            var magicSquare = magicSquareGenerator.Generate(6);
            Console.WriteLine(magicSquare);
            Console.ReadKey();
        }
    }
}
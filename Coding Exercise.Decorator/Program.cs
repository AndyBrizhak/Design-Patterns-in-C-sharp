using System;

namespace Coding_Exercise.Decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dragon = new Dragon();
            dragon.Age = 3;
            Console.WriteLine(dragon);
            Console.ReadKey();
        }
    }
}
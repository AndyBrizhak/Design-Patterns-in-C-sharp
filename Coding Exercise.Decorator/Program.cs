using System;

namespace Coding_Exercise.Decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dragon = new Dragon();
            dragon.Age = 1;
            
            
            Console.WriteLine(dragon.Crawl());
            Console.WriteLine(dragon.Fly());
            Console.ReadKey();
        }
    }
}
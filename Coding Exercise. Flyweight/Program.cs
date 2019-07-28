using System;

namespace Coding_Exercise._Flyweight
{
  internal class Program
    {
        public static void Main(string[] args)
        {
            var sentence = new Sentence("hello word");
            sentence[1].Capitalize = true;
            Console.WriteLine(sentence);
            Console.ReadKey();
        }
    }
}
using System;

namespace FactoryCodingExcercise
{
    public static class Program
    {
        
        
        public static void Main(string[] args)
        {
            
            var person1 = PersonFactory.CreatePerson("Vasia");
            Console.WriteLine(person1);
            Console.WriteLine(person1.Id);
            Console.WriteLine(person1.Name);
            Console.ReadKey();
            var person2 = PersonFactory.CreatePerson("Ivan");
            Console.WriteLine(person2);
            Console.WriteLine(person2.Id);
            Console.WriteLine(person2.Name);
            Console.ReadKey();
            
            
        }
    }
}
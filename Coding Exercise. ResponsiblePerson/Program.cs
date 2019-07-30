using System;

namespace Coding_Exercise._ResponsiblePerson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var person = new Person();
            person.Age = 15;
            
            var  driver= new ResponsiblePerson(person);
            
            Console.WriteLine(driver.DrinkAndDrive());
            
        }
    }
}
using System;

namespace DotNetDesignPatternDemos.Behavioral.Observer
{
  internal class Program
    {
        public static void Main(string[] args)
        {
          
          var person = new Person();

          person.FallsIll += CallDoctor;

          person.CatchACold();
          
          
        }
        
        private static void CallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
          Console.WriteLine($"A doctor has been called to {eventArgs.Address}");
        }
        
        
    }
}
namespace Coding_Exercise.Decorator
{
    public class Dragon       // no need for interfaces
    {
      private Bird bird = new Bird();
      private Lizard lizard = new Lizard();
      private int age;

      public int Age
      {
          get { return age; }
          set
          {
              age = value;
              bird.Age = value;
              lizard.Age = value;
          }
      }

      public string Fly()
             {
              return bird.Fly();
             }
       
             public string Crawl()
             {
               return lizard.Crawl();
             } 
    }
}
namespace Coding_Exercise.Decorator
{
    public class Dragon       // no need for interfaces
    {
      private Bird bird = new Bird();
      private Lizard lizard = new Lizard();
      
        public int Age
             {
               // todo :)
             }
       
             public string Fly()
             {
               bird.Fly();
             }
       
             public string Crawl()
             {
               // todo
             } 
    }
}
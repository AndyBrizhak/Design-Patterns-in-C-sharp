namespace Coding_Exercise.Decorator
{
    public class Lizard
    {
        public int Age { get; set; }
              
              public string Crawl()
              {
                return (Age > 1) ? "crawling" : "too young";
              }
    }
}
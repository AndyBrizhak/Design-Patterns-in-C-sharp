namespace Coding_Exercise.Decorator
{
    public class Bird
    {
        public int Age { get; set; }
              
              public string Fly()
              {
                return (Age < 10) ? "flying" : "too old";
              }
    }
}
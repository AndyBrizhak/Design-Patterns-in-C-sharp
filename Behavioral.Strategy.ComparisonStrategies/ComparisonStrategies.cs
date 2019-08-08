using System.Collections.Generic;

namespace Behavioral.Strategy.ComparisonStrategies
{
    public class ComparisonStrategies
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();
      
            // equality == != and comparison < = >
      
            people.Sort(); // meaningless by default
      
            // sort by name with a lambda
            people.Sort((x, y) => x.Name.CompareTo(y.Name));
      
            people.Sort(Person.NameComparer);

        }
    }
}
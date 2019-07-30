namespace Coding_Exercise._ResponsiblePerson
{
    public class Person
    {
        public int Age { get; set; }
    
        public string Drink()
        {
            return "drinking";
        }
    
        public string Drive()
        {
            return "driving";
        }
    
        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }
}
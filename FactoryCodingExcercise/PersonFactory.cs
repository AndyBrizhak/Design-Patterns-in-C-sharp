namespace FactoryCodingExcercise
{
    /// <summary>
    /// лллл
    /// </summary>
    public class PersonFactory
    {
        private static int _index = 0;
        
        public static Person CreatePerson(string name)
        {
            var p = new Person();
            p.Id = _index;
            p.Name = name;
            _index++;
            return p;
        }
    }
}
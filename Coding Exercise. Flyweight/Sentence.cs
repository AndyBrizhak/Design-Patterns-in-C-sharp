namespace Coding_Exercise._Flyweight
{
    public class Sentence
    {
        public Sentence(string plainText)
        {
            // todo
        }
    
        public WordToken this[int index]
        {
            get
            {
                // todo
            }
        }
    
        public override string ToString()
        {
            // output formatted text here
        }
    
        public class WordToken
        {
            public bool Capitalize;
        }
    }
}
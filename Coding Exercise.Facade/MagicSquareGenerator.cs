using System.Collections.Generic;

namespace Coding_Exercise.Facade
{
    public class MagicSquareGenerator
    {
        public List<List<int>> Generate(int size)
        {
            var generator = new Generator();
            
            var splitter = new Splitter();
            
            
            var verifier = new Verifier();

            var sq = new List<List<int>>();

            do
            {
                for (int i = 0; i < size; ++i)
                {
                    sq = new List<List<int>>();
                    var generation = generator.Generate(size);
                    sq.Add(generation);
                }
            } while (!verifier.Verify(splitter.Split(sq)));
            return sq;
        }
    }
}
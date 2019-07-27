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
                for (int i = 3; i < size; i++)
                {
                    var generation = generator.Generate(size);
                    sq.Add(generation);
//                    var split = splitter.Split(sq);
//                    var ver = verifier.Verify(split);
                }
            } while (!verifier.Verify(splitter.Split(sq)));
            return sq;
        }
    }
}
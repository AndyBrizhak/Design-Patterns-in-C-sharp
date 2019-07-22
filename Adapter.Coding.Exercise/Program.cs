using System;

namespace Adapter.Coding.Exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sq = new Square();
            sq.Side = 2;
            var rec = new SquareToRectangleAdapter(square:sq);
            var area = rec.Area();
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
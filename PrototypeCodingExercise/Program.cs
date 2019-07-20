using System;

namespace PrototypeCodingExercise
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
    public class Point:IPrototype<Point>
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point DeepCopy()
        {
            return new Point(X,Y);
        }

        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }
    }
    
    public class Line : IPrototype<Line>
        {
            public Line(Point start, Point end)
            {
                Start = start;
                End = end;
            }

            public Point Start, End;

          public Line DeepCopy()
          {
            return new Line(Start.DeepCopy(), End.DeepCopy());
          }

          public override string ToString()
          {
              return $"{nameof(Start)}: {Start}, {nameof(End)}: {End}";
          }
        }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
           var line1 = new Line(start: new Point(0,0), end: new Point(1,1));
           Console.WriteLine(line1);
           Console.ReadKey();
        }
    }
}
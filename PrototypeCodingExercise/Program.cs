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
        }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
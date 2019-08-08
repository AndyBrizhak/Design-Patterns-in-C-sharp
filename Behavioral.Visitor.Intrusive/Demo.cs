using System;
using System.Text;

namespace Behavioral.Visitor.Intrusive
{
    public class Demo
    {
        private static void Main(string[] args)
        {
            var e = new AdditionExpression(
                left: new DoubleExpression(1),
                right: new AdditionExpression(
                    left: new DoubleExpression(2),
                    right: new DoubleExpression(3)));
            var sb = new StringBuilder();
            e.Print(sb);
            Console.WriteLine(sb);

            // what is more likely: new type o rnew operation
        }
    }
}
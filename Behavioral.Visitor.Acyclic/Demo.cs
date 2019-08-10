using System;

namespace Behavioral.Visitor.Acyclic
{
    public class Demo
    {
        public static void Main()
        {
            var e = new AdditionExpression(
                left: new DoubleExpression(1),
                right: new AdditionExpression(
                    left: new DoubleExpression(2),
                    right: new DoubleExpression(3)));
            var ep = new ExpressionPrinter();
            ep.Visit(e);
            Console.WriteLine(ep.ToString());

//            var calc = new ExpressionCalculator();
//            calc.Visit(e);
//            Console.WriteLine($"{ep} = {calc.Result}");
        }
    }
}
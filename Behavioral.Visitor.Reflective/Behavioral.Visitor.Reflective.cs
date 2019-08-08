using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Visitor.Reflective
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
      var sb = new StringBuilder();
      ExpressionPrinter.Print2(e, sb);
      Console.WriteLine(sb);
    }
  }
}
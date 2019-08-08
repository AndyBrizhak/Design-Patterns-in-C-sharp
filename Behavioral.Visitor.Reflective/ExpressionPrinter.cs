using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Visitor.Reflective
{
    public static class ExpressionPrinter
    {
        private static Dictionary<Type, Action<Expression, StringBuilder>> actions 
            = new Dictionary<Type, Action<Expression, StringBuilder>>
        {
            [typeof(DoubleExpression)] = (e, sb) =>
            {
                var de = (DoubleExpression) e;
                sb.Append(de.Value);
            },
            [typeof(AdditionExpression)] = (e, sb) =>
            {
                var ae = (AdditionExpression) e;
                sb.Append("(");
                Print(ae.Left, sb);
                sb.Append("+");
                Print(ae.Right, sb);
                sb.Append(")");
            }
        };

        public static void Print(Expression e, StringBuilder sb)
        {
            actions[e.GetType()](e, sb);
        }

        /*public static void Print(Expression e, StringBuilder sb)
        {
            if (e is DoubleExpression de)
            {
                sb.Append(de.Value);
            }
            else 
            if (e is AdditionExpression ae)
            {
                sb.Append("(");
                Print(ae.Left, sb);
                sb.Append("+");
                Print(ae.Right, sb);
                sb.Append(")");
            }
            // breaks open-closed principle
            // will work incorrectly on missing case
        }*/
    }
}
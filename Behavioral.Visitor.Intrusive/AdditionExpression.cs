using System;
using System.Text;

namespace Behavioral.Visitor.Intrusive
{
    public class AdditionExpression : Expression
    {
        private Expression left, right;

        public AdditionExpression(Expression left, Expression right)
        {
            this.left = left ?? throw new ArgumentNullException(paramName: nameof(left));
            this.right = right ?? throw new ArgumentNullException(paramName: nameof(right));
        }

        public override void Print(StringBuilder sb)
        {
            sb.Append(value: "(");
            left.Print(sb);
            sb.Append(value: "+");
            right.Print(sb);
            sb.Append(value: ")");
        }
    }
}
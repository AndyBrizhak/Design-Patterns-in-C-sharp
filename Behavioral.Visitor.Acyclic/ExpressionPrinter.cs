using System.Text;

namespace Behavioral.Visitor.Acyclic
{
    public class ExpressionPrinter : IVisitor, 
        IVisitor<Expression>,
        IVisitor<DoubleExpression>,
        IVisitor<AdditionExpression>
    
    {
        StringBuilder sb = new StringBuilder();

        public void Visit(DoubleExpression obj)
        {
            sb.Append(obj.Value);
        }

        public void Visit(AdditionExpression obj)
        {
            sb.Append("(");
            obj.Left.Accept(this);
            sb.Append("+");
            obj.Right.Accept(this);
            sb.Append(")");
        }

        public override string ToString() => sb.ToString();
    }
}
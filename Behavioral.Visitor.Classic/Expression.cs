namespace Behavioral.Visitor.Classic
{
    public abstract class Expression
    {
        public abstract void Accept(IExpressionVisitor visitor);
    }
}
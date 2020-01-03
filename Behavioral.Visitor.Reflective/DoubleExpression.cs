namespace Behavioral.Visitor.Reflective
{
    
    /// <summary>
    /// +
    /// </summary>
    public class DoubleExpression : Expression
    {
        public double Value;

        public DoubleExpression(double value)
        {
            Value = value;
        }
    }
}
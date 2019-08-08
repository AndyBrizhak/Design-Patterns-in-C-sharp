using System.Text;

namespace Behavioral.Visitor.Intrusive
{
    public abstract class Expression
    {
        // adding a new operation
        public abstract void Print(StringBuilder sb);
    }
}
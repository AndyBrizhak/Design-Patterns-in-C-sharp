using System;
using System.Text;
namespace Behavioral.Visitor.Acyclic
{
    public interface IVisitor<TVisitable>
    {
        void Visit(TVisitable obj);
    }
    
    public interface IVisitor{}
}
using System.Text;

namespace Behavioral.Strategy.Static
{
    public interface IListStrategy
    {
        void Start(StringBuilder sb);
        void End(StringBuilder sb);
        void AddListItem(StringBuilder sb, string item);
    }
}
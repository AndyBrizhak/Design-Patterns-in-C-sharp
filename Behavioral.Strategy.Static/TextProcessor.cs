using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.Static
{
    public class TextProcessor<LS> where LS : IListStrategy, new()
    {
        private StringBuilder sb = new StringBuilder();
        private IListStrategy listStrategy = new LS();

        public void AppendList(IEnumerable<string> items)
        {
            listStrategy.Start(sb);
            foreach (var item in items)
                listStrategy.AddListItem(sb, item);
            listStrategy.End(sb);
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
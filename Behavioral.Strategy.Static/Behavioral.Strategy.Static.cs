using System;

namespace Behavioral.Strategy.Static
{
  // a.k.a. policy

  class Demo
  { 
    static void Main(string[] args)
    {
      var tp = new TextProcessor<MarkdownListStrategy>();
      tp.AppendList(new []{"foo", "bar", "baz"});
      Console.WriteLine(tp);

      var tp2 = new TextProcessor<HtmlListStrategy>();
      tp2.AppendList(new[] { "foo", "bar", "baz" });
      Console.WriteLine(tp2);
    }
  }
}
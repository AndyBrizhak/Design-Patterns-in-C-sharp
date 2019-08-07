using System;

namespace Behavioral.Strategy.Dynamic
{
    class Demo
    { 
        static void Main(string[] args)
        {
            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new []{"foo", "bar", "baz"});
            Console.WriteLine(tp);
            Console.ReadKey();

            tp.Clear();
            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(tp);
              Console.ReadKey();
        }
    }
}
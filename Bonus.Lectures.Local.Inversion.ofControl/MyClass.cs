using System.Collections.Generic;

namespace Bonus.Lectures.Local.Inversion.ofControl
{
    public class MyClass
    {
        public void AddingNumbers()
        {
            var list = new List<int>();
            var list2 = new List<int>();
            //list.Add(24);
            24.AddTo(list,list2);
        }

        public void ProcessCommand(string opcode)
        {
            //if (opcode == "AND" || opcode == "OR" || opcode == "XOR") {}
            //if (new[]{"AND", "OR", "XOR"}.Contains(opcode)) {}
            //if ("AND OR XOR".Split(' ').Contains(opcode)) {}
            if (opcode.IsOneOf("AND", "OR", "XOR")) {}
        }

        public void Process(Person person)
        {
            //if (person.Names.Count == 0) {}
            //if (!person.Names.Any())
            if (person.HasSome(p => p.Names).And.HasNo(p => p.Children)) {}
        }
    }
}
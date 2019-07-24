using System;
using System.Collections.Generic;

namespace Coding_Exercise._Composite
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var singleValue = new SingleValue {Value = 11};
            var otherValues = new ManyValues();
            otherValues.Add(22);
            otherValues.Add(33);
            var sum = new List<IValueContainer> {singleValue, otherValues}.Sum();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
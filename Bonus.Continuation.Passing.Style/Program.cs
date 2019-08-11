using System;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace Bonus.Continuation.Passing.Style
{
    class Program
    {
        static void Main(string[] args)
        {

            var solver = new QuadraticEquationSolver();
            var solutions = solver.Start(1, 10, 16);
            Console.WriteLine("Hello World!");
        }
    }
}
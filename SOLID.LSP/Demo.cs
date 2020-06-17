using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SOLID.LSP
{
    public class Demo
    {
        public static void UseIt(Rectangle r)
        {
            int width = r.Width;
            r.Height = 10;
            WriteLine($"Expected area of {10 * width}, got {r.Area}");
        }

        static void Main()
        {
            var rc = new Rectangle(2, 3);
            UseIt(rc);

            var sq = new Square(5);
            UseIt(sq);
        }
    }
}

   

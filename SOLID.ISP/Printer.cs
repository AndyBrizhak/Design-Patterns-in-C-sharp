using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{

    /// <summary>
    /// only print
    /// </summary>
    public class Printer : IPrinter
    {
        public void Print(Document d)
        {
            //Print
        }
    }
}

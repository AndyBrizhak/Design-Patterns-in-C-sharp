using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    /// <summary>
    /// for print, scan, copy
    /// </summary>
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            //print
        }

        public void Scan(Document d)
        {
            //scan
            //throw new NotImplementedException();
        }
    }
}

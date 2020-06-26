using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    /// <summary>
    /// for only print
    /// </summary>
    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
           //good
        }

        [Obsolete("Not supported", true)]
        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}

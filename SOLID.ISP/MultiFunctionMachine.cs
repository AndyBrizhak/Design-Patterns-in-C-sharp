using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        void IPrinter.Print(Document d)
        {
            throw new NotImplementedException();
        }

        void IScanner.Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}

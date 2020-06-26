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
    public interface IMultiFunctionDevice : IPrinter, IScanner
    {

    }
}

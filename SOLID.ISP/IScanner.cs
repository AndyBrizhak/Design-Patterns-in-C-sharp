using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    /// <summary>
    /// only for scan
    /// </summary>
   public interface IScanner
    {
        void Scan(Document d);
    }
}

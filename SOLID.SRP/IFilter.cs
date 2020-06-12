using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    /// <summary>
    /// Interface for create Filter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }
   
}

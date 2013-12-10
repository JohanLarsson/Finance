using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Tests
{
    /// <summary>
    /// Implementations with no optimizations to use as references in tests
    /// </summary>
    public static class Reference
    {
        public static IEnumerable<double> MovingAverage(IList<double> list, int period)
        {
            int end = list.Count - period + 1;
            for (int i = 0; i < end; i++)
            {
                yield return list.Skip(i).Take(period).Average();
            }
        }
    }
}

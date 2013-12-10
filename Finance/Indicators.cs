using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    public static class Indicators
    {
        public static IEnumerable<double> MovingAverageTravis(double[] list, int period)
        {
            int count = list.Count();
            int total = period < count ? period : count;
            int retSize = count - total > total ? 1 + count - total : total;
            double sum = 0;
            double[] waste = new double[total];
            double fraction = 1.0 / total;
            double[] ret = new double[retSize];
            int retIndex = 0;
            bool shrt = false;
            bool crct = false;
            for (int index = 0; index < count; index++)
            {
                double d = list[index] * fraction;
                sum += d;
                int offset = index % total;
                if (shrt || index >= total)
                {
                    sum -= waste[offset];
                    shrt = true;
                }
                waste[offset] = d;
                if (crct || index >= total - 1)
                {
                    ret[retIndex++] = sum;
                    crct = true;
                }
            }
            return ret;
        }

    }
}

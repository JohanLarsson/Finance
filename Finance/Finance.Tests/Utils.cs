using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Finance.Tests
{
    public class Utils
    {
        public static IEnumerable<double> RandomDoubles(int n)
        {
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                yield return random.NextDouble();
            }
        }

        public static bool AreEqual(double[] first, double[] other, double treshold)
        {
            Assert.AreEqual(first.Length, other.Length);
            for (int i = 0; i < first.Count(); i++)
            {
                Assert.IsTrue((Math.Abs(first[i] - other[i]) < treshold));
            }
            return true;
        }
    }
}

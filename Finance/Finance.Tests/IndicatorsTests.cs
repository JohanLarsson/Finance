using System.Linq;
using NUnit.Framework;

namespace Finance.Tests
{
    public class IndicatorsTests
    {
        [Test]
        public void MovingAverageTest()
        {
            var doubles = Utils.RandomDoubles(500).ToArray();
            var expected = Reference.MovingAverage(doubles, 10).ToArray();
            var actual = Indicators.MovingAverage(doubles, 10).ToArray();
            Utils.AreEqual(expected, actual, 0.001);
        }
    }
}

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
            var period = 10;
            var expected = Reference.MovingAverage(doubles, period).ToArray();
            var actual = Indicators.MovingAverage(doubles, period).ToArray();
            Utils.AreEqual(expected, actual, 0.001);

            var result = FSharp.Finance.something.ma(doubles, period).ToArray();
            Utils.AreEqual(expected, result, 0.001);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockAngle
{
    [TestClass]
    public class ClockTest
    {
        [TestMethod]
        public void Clock_AngleGrowsBeforeSix_120()
        {
            Clock testClock = new Clock();
            Assert.AreEqual (120, testClock.CheckAngle(4));
        }
        [TestMethod]
        public void Clock_AngleShrinksAfterSix_120()
        {
            Clock testClock = new Clock();
            Assert.AreEqual (120, testClock.CheckAngle(8));
        }
        [TestMethod]
        public void Clock_IsNegativeAfterTwelve_Neg()
        {
            Clock testClock = new Clock();
            Assert.AreEqual (-30, testClock.CheckAngle(13));
        }
    }
}
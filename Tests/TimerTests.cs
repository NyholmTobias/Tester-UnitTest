using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddExample;

namespace Tests
{
    [TestClass]
    public class TimerTests
    {
        [TestMethod]
        public void Should_Return_Game_Over_After_30_Sek()
        {
            var timer = new GameTimer();
            var result = timer.CountDown(30);
            Assert.AreEqual("Game Over", result);
        }
    }
}

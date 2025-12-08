
using Tyuiu.DyuvenzhiMI.Sprint6.Task0.V6.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double y = ds.Calculate(x);
            double wait = Math.Round(3 / Math.Sqrt(12), 3);
            Assert.AreEqual(wait, y);
        }
    }
}

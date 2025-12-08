
using Tyuiu.DyuvenzhiMI.Sprint6.Task1.V14.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] y = ds.GetMassFunction(-5, 5);
            double[] wait = new double[] { -2.15, -2.57, -3.00, -3.83, -11.70, 3.00, 2.19, 3.31, 2.97, 1.18, 0.03};
            CollectionAssert.AreEqual(wait, y);
        }
    }
}

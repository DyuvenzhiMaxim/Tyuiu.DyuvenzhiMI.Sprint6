
using Tyuiu.DyuvenzhiMI.Sprint6.Task2.V11.Lib;
namespace Tyuiu.DyuvenzhiMI.Sprint6.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] y = ds.GetMassFunction(-5, 5);
            double[] wait = new double[] { -15.44, -10.93, -7.22, -5.04, 0, -0.30, 2.57, 6.40, 10.04, 12.72, 14.68 };
            CollectionAssert.AreEqual(wait, y);
        }
    }
}

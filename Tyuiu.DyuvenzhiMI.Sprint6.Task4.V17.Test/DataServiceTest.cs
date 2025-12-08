
using Tyuiu.DyuvenzhiMI.Sprint6.Task4.V17.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] wait = new double[] { -0.62, -16.79, -17.77, -6.30, -5.04, -6, -7.85, -2.43, 5.91, 4.33, -11.82 };
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

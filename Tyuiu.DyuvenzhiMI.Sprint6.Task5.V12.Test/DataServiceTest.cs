using Tyuiu.DyuvenzhiMI.Sprint6.Task5.V12.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task5.V12.Tet
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\programming\repos\Tyuiu.DyuvenzhiMI.Sprint6\Tyuiu.DyuvenzhiMI.Sprint6.Task5.V12\bin\Debug\net8.0-windows\InPutDataFileTask5V12.txt";
            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);
            Assert.AreEqual(res, res);
        }
    }
}
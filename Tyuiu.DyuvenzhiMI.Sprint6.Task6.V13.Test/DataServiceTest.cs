
using Tyuiu.DyuvenzhiMI.Sprint6.Task6.V13.Lib;
namespace Tyuiu.DyuvenzhiMI.Sprint6.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"D:\programming\repos\Tyuiu.DyuvenzhiMI.Sprint6\Tyuiu.DyuvenzhiMI.Sprint6.Task6.V13\bin\Debug\net8.0-windows\InPutDataFileTask6V13.txt";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(res,res);
        }
    }
}

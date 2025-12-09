
using Tyuiu.DyuvenzhiMI.Sprint6.Task7.V24.Lib;
namespace Tyuiu.DyuvenzhiMI.Sprint6.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"D:\programming\repos\Tyuiu.DyuvenzhiMI.Sprint6\Tyuiu.DyuvenzhiMI.Sprint6.Task7.V24\bin\Debug\net8.0-windows\InPutDataFileTask7V24.csv";
            int[,] mas = ds.GetMatrix(path);

            CollectionAssert.AreEqual(mas,mas); 
        }
    }
}

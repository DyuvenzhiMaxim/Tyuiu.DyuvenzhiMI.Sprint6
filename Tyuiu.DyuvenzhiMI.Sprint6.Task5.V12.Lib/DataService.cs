
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.DyuvenzhiMI.Sprint6.Task5.V12.Lib
{
    public class DataService : ISprint6Task5V12
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] Array = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null )
                {
                    Array[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            // Удаляем из массива неудовлетворяющие условию элементы
            Array = Array.Where(val => val % 5 != 0).ToArray();

            return Array;
        }
    }
}

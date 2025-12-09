using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task7.V24.Lib
{

    public class DataService : ISprint6Task7V24
    {
        public int len = 0;
        public int[,] GetMatrix(string path)
        {
            int[,] matrix = new int[10,10];
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
            /*
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            int[,] Array = new int[len,5];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Array[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            return Array;*/
        }
    }
}

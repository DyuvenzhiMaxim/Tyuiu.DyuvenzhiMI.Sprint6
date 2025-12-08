
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task3.V24.Lib
{
    public class DataService : ISprint6Task3V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i,j] % 2 == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}

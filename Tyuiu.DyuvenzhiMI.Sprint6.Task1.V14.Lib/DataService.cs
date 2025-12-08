
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] ValueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + x == 0)
                {
                    ValueArray[count] = 0;
                    count++;
                }
                else
                {
                    double y = ((2 * x + 6) / (Math.Cos(x) + x)) - 3;
                    ValueArray[count] = Math.Round(y, 2);
                    count++;
                }
            }
            return ValueArray;
        }
    }
}


using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task2.V11.Lib
{
    public class DataService : ISprint6Task2V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] ValueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1 == 0)
                {
                    ValueArray[count] = 0;
                    count++;
                }
                else
                {
                    double y = (Math.Cos(x) / (x+1)) - (Math.Cos(x)*1.3) + (3*x);
                    ValueArray[count] = Math.Round(y, 2);
                    count++;
                }
            }
            return ValueArray;
        }
    }
}

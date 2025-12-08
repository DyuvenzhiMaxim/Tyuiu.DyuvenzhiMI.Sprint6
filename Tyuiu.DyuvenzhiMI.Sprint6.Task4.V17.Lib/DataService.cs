using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyuvenzhiMI.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] ValueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.7 == 0)
                {
                    ValueArray[count] = 0;
                    count++;
                }
                else
                {
                    double y = (Math.Sin(x) / (x+1.7)) - (Math.Cos(x) * 4*x) - 6;
                    ValueArray[count] = Math.Round(y, 2);
                    count++;
                }
            }
            return ValueArray;
        }
    }
}

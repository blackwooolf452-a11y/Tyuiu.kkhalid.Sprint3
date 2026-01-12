using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.kkhalid.Sprint3.Task5.V9.Lib
{
    public class DataService : ISprint3Task5V9
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double totalSum = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double innerSum = 0;
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    innerSum += (1 / Math.Sin(k)) + x;
                }
                totalSum += innerSum;
            }
            return Math.Round(totalSum, 3);
        }
    }
}
using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.kkhalid.Sprint3.Task4.V29.Lib
{
    public class DataService : ISprint3Task4V29
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue; // пропуск x = 0
                }
                sumSeries += Math.Cos(x) / x;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
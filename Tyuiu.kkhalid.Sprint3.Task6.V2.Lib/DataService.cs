using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.kkhalid.Sprint3.Task6.V2.Lib
{
    public class DataService : ISprint3Task6V2
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;
            for (int num = startValue; num <= stopValue; num++)
            {
                for (int d = 1; d <= num; d++)
                {
                    if (num % d == 0)
                    {
                        totalSum += d;
                    }
                }
            }
            return totalSum;
        }
    }
}
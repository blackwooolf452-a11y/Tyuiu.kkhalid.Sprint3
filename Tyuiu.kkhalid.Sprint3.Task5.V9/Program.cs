using System;
using Tyuiu.kkhalid.Sprint3.Task5.V9.Lib;

namespace Tyuiu.kkhalid.Sprint3.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Вычислить сумму сумм ряда по формуле:                                  *");
            Console.WriteLine("* y = Σ(i=1..3) Σ(k=1..14) (1/sin(k) + x), при x = 5                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine($"* x = {x}                                                                *");
            Console.WriteLine($"* startValue1 = {startValue1}                                            *");
            Console.WriteLine($"* stopValue1  = {stopValue1}                                             *");
            Console.WriteLine($"* startValue2 = {startValue2}                                            *");
            Console.WriteLine($"* stopValue2  = {stopValue2}                                             *");
            Console.WriteLine("**************************************************************************");

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Сумма сумм ряда = {res}                                                *");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}
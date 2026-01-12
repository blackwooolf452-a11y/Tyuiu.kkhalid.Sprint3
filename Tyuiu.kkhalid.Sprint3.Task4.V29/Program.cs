using System;
using Tyuiu.kkhalid.Sprint3.Task4.V29.Lib;

namespace Tyuiu.kkhalid.Sprint3.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах               *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #29                                                            *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение    *");
            Console.WriteLine("* функции y = cos(x)/x. При x = 0 пропустить значение.                   *");
            Console.WriteLine("* Полученные значения суммировать.                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine($"* startValue = {startValue}                                              *");
            Console.WriteLine($"* stopValue  = {stopValue}                                               *");
            Console.WriteLine("**************************************************************************");

            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Сумма ряда = {res}                                                     *");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}

using System;
using Tyuiu.kkhalid.Sprint3.Task7.V4.Lib;

namespace Tyuiu.kkhalid.Sprint3.Task7.V4
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
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #4                                                             *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:         *");
            Console.WriteLine("* F(x) = (2x+6)/(cos(x)+x) - 3                                           *");
            Console.WriteLine("* на отрезке [-5;5] с шагом 1. Проверить деление на ноль.                *");
            Console.WriteLine("* При делении на ноль вернуть 0. Округлить до 2 знаков после запятой.   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine($"* startValue = {startValue}                                              *");
            Console.WriteLine($"* stopValue  = {stopValue}                                               *");
            Console.WriteLine("**************************************************************************");

            double[] res = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1,8:f2} |", startValue + i, res[i]);
            }
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}
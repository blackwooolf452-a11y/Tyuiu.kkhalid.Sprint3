using System;
using Tyuiu.kkhalid.Sprint3.Task6.V2.Lib;


namespace Tyuiu.kkhalid.Sprint3.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = 12;
            int stopValue = 18;

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                               *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Халид И.С. | СМАРТб-23-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих      *");
            Console.WriteLine("* числовому отрезку [12, 18] сумму всех делителей каждого числа.         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine($"* startValue = {startValue}                                              *");
            Console.WriteLine($"* stopValue  = {stopValue}                                               *");
            Console.WriteLine("**************************************************************************");

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* Сумма всех делителей всех чисел в отрезке = {res}                     *");
            Console.WriteLine("**************************************************************************");
            Console.ReadKey();
        }
    }
}
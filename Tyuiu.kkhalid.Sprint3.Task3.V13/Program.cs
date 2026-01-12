using System;
using Tyuiu.kkhalid.Sprint3.Task3.V13.Lib;

namespace Tyuiu.kkhalid.Sprint3.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string input = "?sd!! 5gh. s!";

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* КОНВЕРТАЦИЯ СТРОКИ В ЦЕЛОЕ ЧИСЛО (ЦИКЛ FOREACH) - V13      *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine($"Исходная строка: \"{input}\"");
            Console.WriteLine();

            int number = ds.ConvertStringToInt(input);

            Console.WriteLine($"Результат конвертации: {number}");
            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}
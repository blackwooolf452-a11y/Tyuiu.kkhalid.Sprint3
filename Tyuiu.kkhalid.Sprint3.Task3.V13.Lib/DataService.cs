using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.kkhalid.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            StringBuilder digits = new StringBuilder();
            foreach (char ch in value)
            {
                if (Char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
            }
            if (digits.Length == 0)
                return 0;
            return Int32.Parse(digits.ToString());
        }
    }
}
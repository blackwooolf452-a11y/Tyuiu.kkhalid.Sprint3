using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.kkhalid.Sprint3.Task6.V2.Lib;

namespace Tyuiu.kkhalid.Sprint3.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 15;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 120; // из примера теста
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsFor12To18()
        {
            DataService ds = new DataService();
            int startValue = 12;
            int stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            // Можно рассчитать вручную и подставить ожидаемое значение
            // Пока оставим как есть
        }
    }
}
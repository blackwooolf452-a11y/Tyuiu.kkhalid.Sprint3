using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.kkhalid.Sprint3.Task3.V13.Lib;

namespace Tyuiu.kkhalid.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "?sd!! 5gh. s!";
            int res = ds.ConvertStringToInt(value);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
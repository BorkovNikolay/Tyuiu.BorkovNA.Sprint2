using Tyuiu.BorkovNA.Sprint2.Task2.V28.Lib;

namespace Tyuiu.BorkovNA.Sprint2.Task2.V28Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 6;
            bool z = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(z, res);
        }
    }
}

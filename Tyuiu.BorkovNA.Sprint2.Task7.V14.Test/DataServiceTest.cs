using Tyuiu.BorkovNA.Sprint2.Task7.V14.Lib;

namespace Tyuiu.BorkovNA.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            int y = -1;
            DataService ds = new DataService();
            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
        }
    }
}
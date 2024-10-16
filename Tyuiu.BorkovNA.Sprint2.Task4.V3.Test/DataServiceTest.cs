using Tyuiu.BorkovNA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.BorkovNA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1;
            double y = 3;
            DataService ds = new DataService();
            Assert.AreEqual(3.667, ds.Calculate(x,y));
        }
    }
}
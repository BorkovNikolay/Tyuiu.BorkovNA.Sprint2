using Tyuiu.BorkovNA.Sprint2.Task6.V4.Lib;

namespace Tyuiu.BorkovNA.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 4;
            DataService ds = new DataService();
            Assert.AreEqual("червы", ds.FindCardSuit(x));
        }
    }
}
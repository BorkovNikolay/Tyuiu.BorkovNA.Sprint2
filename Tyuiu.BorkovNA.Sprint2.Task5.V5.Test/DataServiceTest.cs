using Tyuiu.BorkovNA.Sprint2.Task5.V5.Lib;

namespace Tyuiu.BorkovNA.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 13;
            DataService ds = new DataService();
            Assert.AreEqual("король", ds.FindCardValue(x));
        }
    }
}
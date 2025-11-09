using Tyuiu.KovalenkoMA.Sprint4.Task7.V15.Lib;
namespace Tyuiu.KovalenkoMA.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int r = 4;
            int c = 2;
            int[,] mtx = new int[r, c];
            string str = "10293847";
            DataService ds = new DataService();
            int res = ds.Calculate(r, c, str);
            Assert.AreEqual(4, res);
        }
    }
}

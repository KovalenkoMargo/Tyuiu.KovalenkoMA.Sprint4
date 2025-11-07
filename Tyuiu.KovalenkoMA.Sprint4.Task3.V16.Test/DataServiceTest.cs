using Tyuiu.KovalenkoMA.Sprint4.Task3.V16.Lib;
namespace Tyuiu.KovalenkoMA.Sprint4.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] a = new int[5, 5] { { 5, 8, 5, 8, 4 }, { 2, 3, 4, 6, 3 }, { 1, 1, 2, 9, 9 }, { 6, 7, 4, 1, 2 }, { 5, 7, 1, 8, 7 } };
            var res = ds.Calculate(a);
            Assert.AreEqual(2, res);
        }
    }
}

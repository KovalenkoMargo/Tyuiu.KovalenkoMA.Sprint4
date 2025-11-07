using Tyuiu.KovalenkoMA.Sprint4.Task2.V23.Lib;
namespace Tyuiu.KovalenkoMA.Sprint4.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 4, 3, 3, 1, 1, 2 };
            var res = ds.Calculate(a);
            Assert.AreEqual(6, res);
        }
    }
}

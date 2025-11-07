using Tyuiu.KovalenkoMA.Sprint4.Task1.V8.Lib;
namespace Tyuiu.KovalenkoMA.Sprint4.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4 };
            var res = ds.Calculate(a);
            Assert.AreEqual(29, res);
        }
    }
}

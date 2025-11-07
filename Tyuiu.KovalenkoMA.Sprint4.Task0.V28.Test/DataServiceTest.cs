using Tyuiu.KovalenkoMA.Sprint4.Task0.V28.Lib;
namespace Tyuiu.KovalenkoMA.Sprint4.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            var res = ds.GetMultEvenArrEl(a);
            Assert.AreEqual(9216,res);

        }
    }
}

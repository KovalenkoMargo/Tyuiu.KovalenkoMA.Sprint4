using Tyuiu.KovalenkoMA.Sprint4.Task6.V6.Lib;
namespace Tyuiu.KovalenkoMA.Sprint4.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            var res = ds.Calculate(mas);
            string[] mas1 = { "Борис", "Ирина"};
            CollectionAssert.AreEqual(mas1, res);
        }
    }
}

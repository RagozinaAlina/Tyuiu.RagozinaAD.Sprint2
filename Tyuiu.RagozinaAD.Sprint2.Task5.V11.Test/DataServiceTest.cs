using Tyuiu.RagozinaAD.Sprint2.Task5.V11.Lib;
namespace Tyuiu.RagozinaAD.Sprint2.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int g = 2025;
            int m = 10;
            int n = 3;
            var res = ds.FindDateOfNextDay(g, m, n);
            string wait = "04.10.2025";
            Assert.AreEqual(wait, res);
        }
    }
}

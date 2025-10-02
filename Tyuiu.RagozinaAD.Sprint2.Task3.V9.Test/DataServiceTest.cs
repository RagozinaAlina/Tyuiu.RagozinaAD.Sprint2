using Tyuiu.RagozinaAD.Sprint2.Task3.V9.Lib;
namespace Tyuiu.RagozinaAD.Sprint2.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondotion1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 23.12;
            Assert.AreEqual(wait , res);
        }
        public void ValidCondotion2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait =1;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondotion3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.2;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondotion4()
        {
            DataService ds = new DataService();
            double x = -14;
            double res = ds.Calculate(x);
            double wait = -154.071;
            Assert.AreEqual(wait, res);
        }
    }
}

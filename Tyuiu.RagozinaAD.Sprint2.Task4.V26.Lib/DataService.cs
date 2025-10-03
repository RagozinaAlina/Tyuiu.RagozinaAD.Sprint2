using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RagozinaAD.Sprint2.Task4.V26.Lib
{
    public class DataService : ISprint2Task4V26
    {
        public double Calculate(double x, double y)
        {
            double z = (x - 2) < (y / 2) ? ((Math.Pow(10 + (2 / Math.Pow(x, 2)),y))) : (Math.Pow(x, 2) - (1 / y));
            return Math.Round(z, 3);

        }
    }
}
public void ValidCondition1()
{
    DataService ds = new DataService();
    double x = 1;
    double y = 2;
    double res = ds.Calculate(x, y);
    double wait = 144;
    Assert.AreEqual(wait, res);
}
public void ValidCondition2()
{
    DataService ds = new DataService();
    double x = 1;
    double y = 2;
    double res = ds.Calculate(x, y);
    double wait = 0.5;
    Assert.AreEqual(wait, res);
}
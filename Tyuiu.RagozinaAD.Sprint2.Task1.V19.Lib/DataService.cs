using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RagozinaAD.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0]=(a<b)|(d>c);
            res[1]=(a+4<b)&(c>d);
            res[2]=(a<b)||(c<d);
            res[3]=(a+4<b)&&(c>d);
            res[4] = !(!res[0]);
            res[5] =(a != b) ^ (c != d);

            return res;
        }
    }
}

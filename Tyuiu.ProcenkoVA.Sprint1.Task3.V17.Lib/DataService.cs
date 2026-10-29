using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ProcenkoVA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            double fraction = Math.Abs(number) - Math.Floor(Math.Abs(number));
            int digits = (int)(fraction * 1000);

            int d1 = digits / 100;
            int d2 = (digits / 10) % 10;
            int d3 = digits % 10;

            return d1 == 0 || d2 == 0 || d3 == 0;
        }
    }
}

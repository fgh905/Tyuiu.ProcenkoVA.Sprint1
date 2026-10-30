using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ProcenkoVA.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            double baseValue = 1 - Math.Tan(x);
            double exponent = 1.0 / Math.Tan(x);

            double res = Math.Pow(baseValue, exponent) + Math.Cos(x - y);
            return Math.Round(res, 3);
        }
    }
}

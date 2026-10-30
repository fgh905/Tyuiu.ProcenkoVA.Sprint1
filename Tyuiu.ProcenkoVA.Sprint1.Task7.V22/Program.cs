using Tyuiu.ProcenkoVA.Sprint1.Task7.V22.Lib;

namespace Tyuiu.ProcenkoVA.Sprint1.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Выражение: z = (1 - tan x)^ctg x + cos(x - y)                           *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x, y);

            Console.WriteLine("Значение выражения Z = " + Math.Round(res, 3));

            Console.ReadKey();
        }
    }
}

using Tyuiu.ProcenkoVA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.ProcenkoVA.Sprint1.Task5.V5
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

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(x));
            Console.WriteLine("Первая цифра дробной части: " + res);

            Console.ReadKey();
        }
    }
}
using Tyuiu.ProcenkoVA.Sprint1.Task4.V20.Lib;

namespace Tyuiu.ProcenkoVA.Sprint1.Task4.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Проценко В. А. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Проценко Владимир Алексеевич | РППб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.Write("Введите значение x: ");
            x = (int)Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            y = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("(1 + X) / |X - Math.Sqrt(2 + Y)| = " + ds.Calculate(x, y));


            Console.ReadKey();
        }
    }
}
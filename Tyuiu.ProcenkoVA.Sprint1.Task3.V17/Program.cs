using Tyuiu.ProcenkoVA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.ProcenkoVA.Sprint1.Task3.V17
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Проценко Владимир Алексеевич | РППб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double number = 123.405;
            Console.WriteLine("Заданное вещественное число = " + number);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Есть ли 0 среди первых 3 цифр дробной части = " + ds.ZeroCheck(number));
            Console.ReadLine();
        }
    }
}
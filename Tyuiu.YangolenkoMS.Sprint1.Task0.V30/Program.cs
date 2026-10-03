namespace Tyuiu.YangolenkoMS.Sprint1.Task0.V30;

using Tyuiu.YangolenkoMS.Sprint1.Task0.V30.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 / Выполнил: Янголенко М. С. / АСОиУб-26-1";

        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #1                                                             *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                      *");
        Console.WriteLine("* Варинат #30                                                           *");
        Console.WriteLine("* Выполнил: Янголенко Матвей Сергеевич / АСОиУб-26-1                    *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу, которая вычисляет выражение            *");
        Console.WriteLine("* и печатает результат на экране.                                       *");
        Console.WriteLine("*                                                                       *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* 20 * 5 - 4                                                            *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
        Console.WriteLine("*************************************************************************");

        Console.WriteLine(ds.Calculate());

        Console.ReadLine();
    }
}

using Tyuiu.RotachAO.Sprint3.Task3.V15.Lib; 
 
namespace Tyuiu.RotachAO.Sprint3.Task3.V15;

class Program
{
    static void Main(string[] args)
    {

        Console.Title = "Спринт #3 | Выполнил: Ротач. А. О. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #3                                                           *");
        Console.WriteLine("* Вариант #15                                                          *");
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string value = "lrmmse mg sermmmrt";
        char chr = 'm';

        Console.WriteLine("Исходная сторка =  " + value);
        Console.WriteLine("Искомый символ = " + chr);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Минимальное количество символов = " + ds.GetMinCharCount(value, chr));

        Console.ReadKey();
    }
}
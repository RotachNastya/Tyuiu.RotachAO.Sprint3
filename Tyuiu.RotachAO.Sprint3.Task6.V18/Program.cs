using Tyuiu.RotachAO.Sprint3.Task6.V18.Lib;

namespace Tyuiu.RotachAO.Sprint3.Task6.V18;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Ротач. А. О. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #6                                                           *");
        Console.WriteLine("* Вариант #18                                                          *");
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        int startValue = 9;
        int stopValue = 18;

        Console.WriteLine("Начало отрезка  = " + startValue);
        Console.WriteLine(" Конец отрезка = " + stopValue);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Сумма делителей = " + ds.GetSumTheDivisors(startValue, startValue));

        Console.ReadKey();  
    }
}


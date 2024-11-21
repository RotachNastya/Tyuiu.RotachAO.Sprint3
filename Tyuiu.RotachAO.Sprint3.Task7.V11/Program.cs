using Tyuiu.RotachAO.Sprint3.Task7.V11.Lib; 
 
namespace Tyuiu.RotachAO.Sprint3.Task7.V11;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Ротач. А. О. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #3                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #7                                                           *");
        Console.WriteLine("* Вариант #11                                                          *");
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");

        int startValue = -5;
        int stopValue = 5;


        int len = ds.GetMassFunction(startValue, stopValue).Length;


        double[] valueWaitArray;
        valueWaitArray = new double[len];

        Console.WriteLine("Старт шага:" + startValue);
        Console.WriteLine("Конец шага:" + stopValue);

        valueWaitArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* Результат:                                                                   *");
        Console.WriteLine("********************************************************************************");

        Console.WriteLine("+--------------+--------------+");
        Console.WriteLine("|         x    |       f(x)   |");
        Console.WriteLine("+--------------+--------------+");



        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}    |       {1, 5:f2}        |", startValue, valueWaitArray[i]);
            startValue++;
        }


        Console.WriteLine("+--------------+--------------+");

        Console.ReadKey();
    }
}
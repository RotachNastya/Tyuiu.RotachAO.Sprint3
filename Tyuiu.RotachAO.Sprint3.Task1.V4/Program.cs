using Tyuiu.RotachAO.Sprint3.Task1.V4.Lib; 
 
namespace Tyuiu.RotachAO.Sprint3.Task1.V4; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService dataService = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #1                                                           *"); 
        Console.WriteLine("* Вариант #4                                                           *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        int startValue = 1;
        int stopValue = 10; 
        Console.WriteLine("Старт шага = "  + startValue); 
        int x = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("Конец шага = " + stopValue); 
        int y = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine($"Сумма ряда = " + ds.GetSumSeries(startValue, stopValue)); 
    } 
} 

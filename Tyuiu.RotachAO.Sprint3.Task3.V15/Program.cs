using Tyuiu.RotachAO.Sprint3.Task3.V15.Lib; 
 
namespace Tyuiu.RotachAO.Sprint3.Task3.V15; 
 
class Program 
{ 
    static void Main(string[] args) 
    {

        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #3                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #15                                                          *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");

        string str = "Glrmmse mg sermmmrt";
        char chr = 'm';
        Console.WriteLine("Исходная строка = " + str);
        Console.WriteLine("Искомый символ = " + chr);
        Console.WriteLine("Количество символов =" + ds.GetMinCharCount(str, chr));
        Console.ReadKey();
    } 
} 
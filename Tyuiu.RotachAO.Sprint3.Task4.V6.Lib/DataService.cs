using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.RotachAO.Sprint3.Task4.V6.Lib;

public class DataService : ISprint3Task4V6
{
    public double Calculate(int startValue, int stopValue)
    {
        double res = 0;
        for (int x = startValue; x < stopValue; x++)
        {
            if (x == 0)
            {
                break;
            }
            else
            {
                res = res + x / ((Math.Cos(x) - Math.Sin(x)));
            }
        }

        return Math.Round(res, 3);
    }
}

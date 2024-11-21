using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.RotachAO.Sprint3.Task7.V11.Lib;

public class DataService : ISprint3Task7V11
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        int x;
        int y = 0;
         double[] mass = new double[stopValue - startValue + 1];
        for (x = startValue; x <= stopValue; x++)
        {
            if (x == 1) mass[y] = 0;
            else
            mass[y] = Math.Round(Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4*x, 2);
            y++;
        }
        return mass;
    }
} 

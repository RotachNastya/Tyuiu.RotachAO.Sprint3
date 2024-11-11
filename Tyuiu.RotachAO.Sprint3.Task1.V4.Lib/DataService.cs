using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.RotachAO.Sprint3.Task1.V4.Lib;

public class DataService : ISprint3Task1V4
{
    public double GetSumSeries(int startValue, int stopValue)
    {
        double sumSeries = 0;
        while (startValue <= stopValue)
        {
            sumSeries = sumSeries + (Math.Pow(1 / startValue, 2));
            startValue++;
        }
        return Math.Round(sumSeries, 3);
    }
}
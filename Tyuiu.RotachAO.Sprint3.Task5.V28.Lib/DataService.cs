using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.RotachAO.Sprint3.Task5.V28.Lib;

public class DataService : ISprint3Task5V28
{
    public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
    {
        int sum = 0;
        int dsum;
        for (int i = startValue; i <= stopValue; i++)

        {
            dsum = 0;
            for (int d = i; d <= i; d++)
                if (i % d == 0)
                    dsum += d;
            if (dsum > 10)
                sum += dsum;
            return sum;
        }
    }
} 

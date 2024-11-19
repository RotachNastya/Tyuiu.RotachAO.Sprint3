using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.RotachAO.Sprint3.Task6.V18.Lib;

public class DataService : ISprint3Task6V18
{
    public int GetSumTheDivisors(int startValue, int stopValue)
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
        }
                    return sum;
                }
    }
}



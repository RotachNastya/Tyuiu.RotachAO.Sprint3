using tyuiu.cources.programming.interfaces.Sprint3; 
 
namespace Tyuiu.RotachAO.Sprint3.Task3.V15.Lib;

public class DataService : ISprint3Task3V15
{
    public int GetMinCharCount(string value, char item)
    {
        int res = 0;
        char letterChr = ' ';
        foreach (char c in value)
        {
            if (c == item)
            {
                if (c == letterChr) res++;
            }
            letterChr = c;
        }
        return res;
    }
}

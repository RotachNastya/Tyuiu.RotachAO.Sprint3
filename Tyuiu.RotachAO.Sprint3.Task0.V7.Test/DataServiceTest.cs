using Tyuiu.RotachAO.Sprint3.Task0.V7.Lib; 
 
namespace Tyuiu.RotachAO.Sprint3.Task0.V7.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        double value = 0.75;
        int startValue = 1;
        int stopValue = 20;
        DataService ds = new DataService();
        double res = ds.GetSumSeries(value, startValue, stopValue);
        double wait = 0;
        Assert.AreEqual(wait,res);
   } 
} 

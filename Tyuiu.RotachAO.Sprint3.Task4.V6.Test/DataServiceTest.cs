using Tyuiu.RotachAO.Sprint3.Task4.V6.Lib; 
 
namespace Tyuiu.RotachAO.Sprint3.Task4.V6.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidCalc()  
   { 
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        double res = ds.Calculate(startValue, stopValue);
        double wait = 8.995;
        Assert.AreEqual(wait, res);

   } 
} 

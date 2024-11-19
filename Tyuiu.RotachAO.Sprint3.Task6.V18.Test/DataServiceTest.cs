using Tyuiu.RotachAO.Sprint3.Task6.V18.Lib; 
 
namespace Tyuiu.RotachAO.Sprint3.Task6.V18.Test; 
 
[TestClass] 
public class DataServiceTest  
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();

        int startValue = 9;
        int stopValue = 18;

        int res = ds.GetSumTheDivisors(startValue, stopValue);
        int wait = 1;
        Assert.AreEqual(res, wait);
   } 
} 

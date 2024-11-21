using Tyuiu.RotachAO.Sprint3.Task7.V11.Lib; 
 
namespace Tyuiu.RotachAO.Sprint3.Task7.V11.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidGetMassFunction()  
   {
        DataService ds = new DataService();

        int startValue = 0;
        int stopValue = 0;


        double[] valueWaitArray = new double[1];
        valueWaitArray[0] = 0.5;

        double[] res = ds.GetMassFunction(startValue, stopValue);
        CollectionAssert.AreEqual(res, valueWaitArray);
    } 
} 

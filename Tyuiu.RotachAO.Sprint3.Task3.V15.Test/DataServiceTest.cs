using Tyuiu.RotachAO.Sprint3.Task3.V15.Lib; 
 
namespace Tyuiu.RotachAO.Sprint3.Task3.V15.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidGetMinCharCount()  
   {
        DataService ds = new DataService();
        string str = "lrmmse mg sermmmrt";
        char chr = 'm';
        double res = ds.GetMinCharCount(str, chr);
        int wait = 3;
        Assert.AreEqual(wait, res);
    } 
} 

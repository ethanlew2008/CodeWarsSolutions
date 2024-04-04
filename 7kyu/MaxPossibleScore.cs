using System.Collections.Generic;

public class Kata
{
  public static int MaxPossibleScore(Dictionary<object, int> obj, object[] arr)
  {
    int total = 0;
    
    foreach(var i in obj)
    {
      total += i.Value;
    }
    
    foreach(var i in arr)
    {
      if(obj.ContainsKey(i))
      {
        total += obj[i];
      }     
    }
    
    return total;
    
  }
}

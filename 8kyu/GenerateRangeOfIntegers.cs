using System.Collections.Generic;
public class Kata 
{
  public static int[] GenerateRange(int min, int max, int step)
  {
    List<int> listname = new List<int>();
      
    for(int i = min; i <= max; i += step)
    {
      listname.Add(i);
    }
    
    return listname.ToArray();        
  }
}

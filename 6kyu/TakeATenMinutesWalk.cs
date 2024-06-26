using System;
using System.Collections;
using static System.Linq.Enumerable;
public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
      var norths = walk.Count(s => s == "n");
      var souths = walk.Count(s => s == "s");
      var easts = walk.Count(s => s == "e");
      var wests = walk.Count(s => s == "w");
    
      int horizontal = easts - wests;
      if(horizontal < 0) { horizontal *= -1;}
    
      int vertical = souths - norths;
      if(vertical < 0){vertical*=-1;}
    
      int time = norths + souths + easts + wests + horizontal + vertical;
      if (time == 10){return true;}
      else {return false;}      
  }
}

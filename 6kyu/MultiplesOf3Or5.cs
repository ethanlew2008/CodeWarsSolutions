using System.Collections.Generic;  
public static class Kata
{
  public static int Solution(int value)
  {
    int total = 0;
    
    for(int i = 0; i < value; i++ )
    {     
      if( i % 3 == 0)
      {
        total += i;
      }     
     else if(i % 5 == 0)
      {
        total += i;
      }         
    }
    return total;    
  }
}

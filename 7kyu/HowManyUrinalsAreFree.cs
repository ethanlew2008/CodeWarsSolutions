using System;

namespace Solution 
{
  public static class FreeUrinals
  {
    public static int GetFreeUrinals(string urinals)
    {
      
      char[] chars = urinals.ToCharArray();
      int counter = 0;
      if(chars.Length == 1)
      {
        if(chars[0] == '0'){return 1;} else{return 0;}
      }

      for (int i = 0; i < chars.Length; i++)
      {
        if(i == 0)
        {
          if (chars[i] == '0' && chars[i + 1] == '0') { counter++; chars[i] = '1'; }
          if(chars[i] == '1' && chars[i+1] == '1'){return -1;}
          continue;
        }

        if(i == chars.Length - 1)
        {
          if (chars[i] == '0' && chars[i - 1] == '0') { counter++; chars[i] = '1'; }
          if(chars[i] == '1' && chars[i-1] == '1'){return -1;}
          continue;
        }

        
        if (chars[i] == '0' && chars[i - 1] == '0' && chars[i + 1] == '0') { counter++; chars[i] = '1'; }
        if(chars[i] == '1' && chars[i+1] == '1'|| chars[i] == '1' && chars[i-1] == '1'){return -1;}
      }
           
      return counter;
    }
  }
}

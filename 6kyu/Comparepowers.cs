using System;
class Kata
{
    public static int ComparePowers(int[] a, int[] b)
    {
      double one = a[1] * Math.Log(a[0]);
      double two = b[1] * Math.Log(b[0]);
        
      if(one>two){return -1;}
      if(one == two){return 0;}
      else{return 1;} 
    }
}

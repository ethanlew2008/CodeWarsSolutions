using System;

public static class Kata
{
  public static string CountSheep(int n)
  {
    int count = 1;
    string sheep = "";
    while(count <= n)
    {
      sheep += count + " sheep...";
      count++;
      }
    
    return sheep;
  }
}

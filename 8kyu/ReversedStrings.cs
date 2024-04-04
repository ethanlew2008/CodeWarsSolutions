using System;

public static class Kata
{
  public static string Solution(string str) 
  {
      char[] chars = str.ToCharArray();
      Array.Reverse(chars);
      return new string(chars);  
  }
}

using System;

public class Kata
{
  public static int Litres(double time)
  {
    double drink = 0.5 * time;
    int Result = (int)Math.Floor(drink);
    return Result;
  }
     
}

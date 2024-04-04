using System;
public class Kata  
{
  public static int CookingTime(int eggs)
  {
    double temp;
    double batches;
    
    batches = (double)eggs / 8;
    temp = Math.Ceiling(batches);
    batches = temp;
    return (int)batches * 5;
  }
}

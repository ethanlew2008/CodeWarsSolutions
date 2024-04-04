using System;

public class Kata
{
  public static string GoodVsEvil(string good, string evil) 
  {
      int goodscore = 0;
      int evilscore = 0;


      int[] goodvalues = { 1, 2, 3, 3, 4, 10 };
      int[] evilvalues = { 1, 2, 2, 2, 3, 5, 10 };


      var goodunits = good.Split(' ');
      var evilunits = evil.Split(' ');


      for (int i = 0; i <goodunits.Length; i++)
      {     
        goodscore += Convert.ToInt32(goodunits[i]) * goodvalues[i];
      }

      for (int i = 0; i < evilunits.Length; i++)
      {
        evilscore += Convert.ToInt32(evilunits[i]) * evilvalues[i];
      }


      if(goodscore > evilscore)
      {
        return "Battle Result: Good triumphs over Evil";
      }
      else if(evilscore > goodscore)
      {
          return "Battle Result: Evil eradicates all trace of Good";
      }
      else
      {
          return "Battle Result: No victor on this battle field";
      }  
  }
}

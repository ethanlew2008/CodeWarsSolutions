using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    string[] x;
    string result = "";

    x = str.Split('-','_');         
    result += x[0];

    for (int i = 1; i < x.Length; i++)
    {
        result += char.ToUpper(x[i][0]) + x[i].Substring(1);
    }

    return result;
  }
}

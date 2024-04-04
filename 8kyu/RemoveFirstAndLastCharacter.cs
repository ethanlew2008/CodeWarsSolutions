using System;

public class Kata
{
    public static string Remove_char(string stri)
    {    
        stri = stri.Remove(0, 1);
        stri = stri.Remove(stri.Length - 1, 1);
        return stri;
    }
}

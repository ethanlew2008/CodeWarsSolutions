using System;

public class Printer 
{
    public static string PrinterError(String s) 
    {
        int err = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] > 'm')
            {
                err++;
            }
                
        }

        return(err + "/" + s.Length);       
    }
}

public class Kata
{
  public static string SortMyString(string s)
  {
    string evenletter = "";
    string oddletter = "";
    for (int i = 0; i < s.Length; i++)
    {
      if (i % 2 == 0) { evenletter += s[i]; }
      else { oddletter += s[i]; }          
    }
         
    return evenletter + " " + oddletter;
  }
}

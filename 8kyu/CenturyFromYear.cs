public static class Kata
{
  public static int СenturyFromYear(int year)
  {
	int x  = 0;
	if(year % 100 == 0)
	{
		x = year / 100;
	}
	else {x = (year/100) + 1; }
    
	return x;    
  }
}

public class Kata
{
  public static string GetPlanetName(int id)
  {
    string name = "";
    if(id == 1)
    {
      name = "Mercury";
    }
    else if(id == 2)
    {
      name = "Venus";      
    }
    else if(id == 3)
    {
      name = "Earth";
    }
    else if(id == 4)
    {
      name = "Mars";
    }
    else if(id == 5)
    {
      name = "Jupiter";
    } 
    else if(id == 6)
    {
      name = "Saturn";
    }
    else if(id == 7)
    {
      name = "Uranus";
    }
    else if(id == 8)
    {
      name = "Neptune";
    }
        
    
      
    return name;
  }
}

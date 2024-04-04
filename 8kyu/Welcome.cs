using System.Collections.Generic;
using System.Linq;
public static class Kata  
{
  public static string Greet(string language)
  {
    Dictionary<string, string> languages = new Dictionary<string, string>()
    {
      {"english", "Welcome"},
      {"czech", "Vitejte"},
      {"danish", "Velkomst"},
      {"dutch", "Welkom"},
      {"estonian", "Tere tulemast"},
      {"finnish", "Tervetuloa"},
      {"flemish", "Welgekomen"},
      {"french", "Bienvenue"},
      {"german", "Willkommen"},
      {"irish", "Failte"},
      {"italian", "Benvenuto"},
      {"latvian", "Gaidits"},
      {"lithuanian", "Laukiamas"},
      {"polish", "Witamy"},
      {"spanish", "Bienvenido"},
      {"swedish", "Valkommen"},
      {"welsh", "Croeso"}
    };
          
    var x = languages.FirstOrDefault(l => l.Key == language);
    if(x.Key != null){return x.Value;}
    else{return languages["english"];}         
    }
}

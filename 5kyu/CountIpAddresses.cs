public static long IpsBetween(string start, string end)
{
    var startarray = start.Split('.');
    var endarray = end.Split(".");

    byte[] t =
    {
      Convert.ToByte(startarray[0]),
      Convert.ToByte(startarray[1]),
      Convert.ToByte(startarray[2]),
      Convert.ToByte(startarray[3])
    };
      
    byte[] t2 =
    {
      Convert.ToByte(endarray[0]),
      Convert.ToByte(endarray[1]),
      Convert.ToByte(endarray[2]),
      Convert.ToByte(endarray[3])
    };
      
      
    if (BitConverter.IsLittleEndian)
    {
      Array.Reverse(t);
      Array.Reverse(t2);
    }
      
    var addr1 = BitConverter.ToUInt32(t);
    var addr2 = BitConverter.ToUInt32(t2);
      
    return (addr2 - addr1);
}


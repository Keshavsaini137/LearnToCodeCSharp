using System;

namespace EnumerationApp{
  //enum is value data type which contains its own values
  public enum days{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thusday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
  }
  class Enumeration {
    public static void Main(String []args){
      var method = days.Monday;//Now var is enum type
      Console.WriteLine((int)method);

      var methodId = 5;
      //Now MethodId is converted into enum.
      Console.WriteLine((days)methodId);

      //Convert the enum (method) into String.
      Console.WriteLine(method.ToString());


    }
  }
}

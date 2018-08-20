using System;

namespace TypeConversionApplications{
  class TypeConversion{
    public static void Main(string[] args){
      int i;
      double d = 20.1234d;
      float f = 23.12f;
      bool b = false;

      i = (int)d;
      Console.WriteLine(i);

      i = (int)f;
      Console.WriteLine(i);

      Console.WriteLine(i.ToString());
      Console.WriteLine(f.ToString());
      Console.WriteLine(d.ToString());
      Console.WriteLine(b.ToString());
      Console.WriteLine(i);
    }
  }
}

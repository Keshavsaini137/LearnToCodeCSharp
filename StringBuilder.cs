
using System;
using System.Text;

namespace StringBuildersApp{
  class StringBuilders{
    public static void Main(String[] args){
      var builder = new StringBuilder();

      builder.Append('-', 10);
      builder.AppendLine()
      .Append("Header")
      .AppendLine()
      .Append('-', 10)

      .Replace('-', '+')
      .Remove(0,10);

      builder.Insert(0, new String('-', 10));

      Console.WriteLine(builder);

      Console.WriteLine(builder[12]);
    }
  }
}

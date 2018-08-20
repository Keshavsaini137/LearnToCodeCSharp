using System;

namespace TimeSpanApp{
  class TimeSpanProgram{
    public static void Main(String [] args){

      TimeSpan timeSpan = new TimeSpan(2,3,5);

      var timeSpan1 = new TimeSpan(1, 0, 0);
      var timeSpan2 = TimeSpan.FromHours(1);
      var timeSpan3 = TimeSpan.FromMinutes(6);

      var start = DateTime.Now;
      var end = DateTime.Now.AddMinutes(2);
      var duration = end - start;
      Console.WriteLine(duration);

      //Properties
      Console.WriteLine("Minutes : " + timeSpan.Minutes);
      Console.WriteLine("Total Minutes : " + timeSpan.TotalMinutes);

      //Add
      Console.WriteLine("Add :" + timeSpan.Add(TimeSpan.FromMinutes(7)));
      Console.WriteLine("Subtract :" + timeSpan.Subtract(TimeSpan.FromMinutes(3)));

      //ToString
      Console.WriteLine("ToString : " + timeSpan.ToString());

      //Parse
      Console.WriteLine("Parse: " + TimeSpan.Parse("02:03:04"));
    }
  }
}

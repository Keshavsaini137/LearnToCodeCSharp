using System;

namespace DataTimeApp{
  class DataTime{
    public static void Main(String[] args){

      DateTime dateTime = new DateTime(2018, 7, 13);
      var now = DateTime.Now;
      var today = DateTime.Today;

      Console.WriteLine("Hour: {0}", now.Hour);
      Console.WriteLine("Hour: {0}", now.Minute);
      Console.WriteLine(today);

      var tomrrow = now.AddDays(1);
      var yesterday = now.AddDays(-1);

      Console.WriteLine(tomrrow);
      Console.WriteLine(yesterday);

      Console.WriteLine(now.ToLongDateString());
      Console.WriteLine(now.ToShortDateString());
      Console.WriteLine(now.ToLongTimeString());
      Console.WriteLine(now.ToShortDateString());

      Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));

    }
  }
}

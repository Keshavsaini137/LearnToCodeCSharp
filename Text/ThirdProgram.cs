/*3- Write a program and ask the user to enter a
time value in the 24-hour time format (e.g.
19:00). A valid time should be between 00:00 and
23:59. If the time is valid, display "Ok";
otherwise, display "Invalid Time". If the user
doesn't provide any values, consider it as invalid
time.
*/

using System;

namespace ThirdProgramApp{
  class ThirdProgram{
    static void Main(String[] args){
      Console.WriteLine("Enter Time: ");
      var input = Console.ReadLine();

      if(String.IsNullOrWhiteSpace(input)){
        Console.WriteLine("InValid Time");
        return;
      }

      var inputLists = input.Split(':');

      foreach(var number in inputLists){
        if(number.Length != 2){
          Console.WriteLine("InValid");
          return;
        }
      }
      int hour = Convert.ToInt32(inputLists[0]);
      int minute = Convert.ToInt32(inputLists[1]);

      if(hour > 0 && hour < 24 && minute < 60 && minute > 0){
        Console.WriteLine("OK");
      }
      else{
        Console.WriteLine("InValid");
      }

    }
  }
}

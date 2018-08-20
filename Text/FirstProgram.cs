/*1- Write a program and ask the user to enter a
few numbers separated by a hyphen. Work out if the
numbers are consecutive. For example, if the input
is "5-6-7-8-9" or "20-19-18-17-16", display a
message: "Consecutive"; otherwise, display "Not
Consecutive".
*/
using System.Collections.Generic;
using System;

namespace FirstProgram{
  class FirstProgram{
    public static void Main(String[] args){
      Console.WriteLine("Enter a few numbers separated by a hyphen.");
      String numbers = Console.ReadLine();

      List<int> singleNumbers = new List<int>();
      foreach(var number in numbers.Split('-')){
        singleNumbers.Add(Convert.ToInt32(number));
      }

      singleNumbers.Sort();
      foreach(var singleNumber in singleNumbers){
      Console.WriteLine(singleNumber);
    }
Console.WriteLine("Consecutive" + singleNumbers.Count);
    for(int i = 0; i < singleNumbers.Count - 1;i++){
      if(singleNumbers[i] == singleNumbers[i + 1] - 1){
        Console.WriteLine("Consecutive");
      }
      else{
        Console.WriteLine("Not Consecutive");
        break;
      }
    }

    }
  }
}

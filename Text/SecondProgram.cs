/*2- Write a program and ask the user to enter a
few numbers separated by a hyphen. If the user
simply presses Enter, without supplying an input,
exit immediately; otherwise, check to see if there
are duplicates. If so, display "Duplicate" on the
console.
*/
using System.Collections.Generic;
using System;

namespace SecondProgramApp{
  class SecondProgram{
    public static void Main(String[] args){
      Console.WriteLine("Enter a few numbers separated by a hyphen.");
      String numbers = Console.ReadLine();

      List<int> numbersList = new List<int>();

      foreach(var number in numbers.Split('-')){
        numbersList.Add(Convert.ToInt32(number));
      }
      List<int> uniqueList = new List<int>();
      for(int i = 0; i<numbersList.Count;i++){
        if(!uniqueList.Contains(numbersList[i])){
        uniqueList.Add(numbersList[i]);
      }
      else{
        Console.WriteLine("Duplicate");
      }
      }

    //   foreach(var number in uniqueList){
    //   if(uniqueList.Contains(number)){
    //     Console.WriteLine("Duplicate");
    //   }
    // }
    }
  }
}

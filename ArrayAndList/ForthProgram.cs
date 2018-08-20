/*4- Write a program and ask the user to
continuously enter a number or type "Quit" to
exit. The list of numbers may include duplicates.
Display the unique numbers that the user has
entered.
*/

using System.Collections.Generic;
using System;

namespace ForthProgramApp{
  class ForthProgram{
    public static void Main(String [] args){
      List<int> numbersList = new List<int>();

      while(true){
        Console.WriteLine("Enter a Number: ");
        var userInput = Console.ReadLine();
        if(userInput.Equals("quit"))
        break;
        numbersList.Add(Convert.ToInt32(userInput));
      }

      List<int> uniquesList = new List<int>();

      for(int i = 0;i<numbersList.Count;i++){
        if(!uniquesList.Contains(numbersList[i])){
          uniquesList.Add(numbersList[i]);
        }
      }

      foreach(var uniqueNumber in uniquesList){
        Console.WriteLine("{0}", uniqueNumber);
      }
    }
  }
}

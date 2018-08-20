/*5- Write a program and ask the user to enter a
series of numbers separated by comma. Find the
maximum of the numbers and display it on the
console. For example, if the user enters “5, 3,
8, 1, 4", the program should display 8.
*/

using System;

namespace FifthProgramApp{
  class FifthProgram{
    public static void Main(String[] args){

      Console.WriteLine("Enter a series of numbers separated by comma.");
      String numbersString = Console.ReadLine();

      char delimiter = ',';


      var substrings = numbersString.Split(delimiter);

      var max = Convert.ToInt32(substrings[0]);

      for(int i = 0; i<substrings.Length;i++){
         var newNumber = Convert.ToInt32(substrings[i]);

         if(max < newNumber){
           max = newNumber;
         }

      }
      Console.WriteLine(max);

    }

  }
}

/*3- Write a program and ask the user to enter 5
numbers. If a number has been previously entered,
display an error message and ask the user to
re-try. Once the user successfully enters 5
unique numbers, sort them and display the result
on the console.
*/

using System.Collections.Generic;
using System;

namespace ThirdProgramApp{
  class ThirdProgram{
    public static void Main(String[] args){
      List<int> numbersList = new List<int>();

      Console.WriteLine("Enter 5 Numbers: ");

      for(int i = 0; ;i++){

        int userEnteredNum = Convert.ToInt32(Console.ReadLine());

        if(!numbersList.Contains(userEnteredNum)){

          numbersList.Add(userEnteredNum);
          if(numbersList.Count == 5){
            break;
          }
        }
        else{
          Console.WriteLine("Re-Try");
        }

      }

      numbersList.Sort();
      foreach(var number in numbersList){
        Console.WriteLine(number);
      }


    }
  }
}

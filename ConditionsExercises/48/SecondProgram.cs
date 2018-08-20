/*2- Write a program and continuously
 ask the user to enter a number or "ok"
to exit. Calculate the sum of all the
 previously entered numbers and display
it on the console.*/

using System;

namespace SecondProgramApp{
  class SecondProgram{
    public static void Main(String[] args){
      int sum = 0;
      for(;;){
         var newNumber = Console.ReadLine();

         if(newNumber == "ok"){
           break;
         }

         sum = sum + Convert.ToInt32(newNumber);
      }
      Console.WriteLine("Sum of all Previous numbers is {0}", sum);
    }
  }
}

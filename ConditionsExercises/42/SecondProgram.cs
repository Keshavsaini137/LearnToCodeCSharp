/*2- Write a program which takes two
 numbers from the console and displays
 the maximum of the two.
*/

using System;

namespace SecondProgramApp{
  class SecondProgram{
    public static void Main(String[] args){
      Console.WriteLine("Enter the First Number : ");
      int FirstNum = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the Second Number : ");
      int SecondNum = Convert.ToInt32(Console.ReadLine());

      if(FirstNum == SecondNum){
        Console.WriteLine("Both are Same");
      }
      else{
        if(FirstNum > SecondNum){
          Console.WriteLine("{0} is the Bigger", FirstNum);
        }
        else{
          Console.WriteLine("{0} is the Bigger", SecondNum);
        }
      }
    }
  }
}

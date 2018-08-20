/*1- Write a program to count how many
 numbers between 1 and 100 are divisible
 by 3 with no remainder. Display the
 count on the console.*/

using System;

namespace FirstProgram{
  class FirstProgram{
    public static void Main(String[] args){
      int count = 0;
      int divisibleBy = 3;
      for(int i = 1; i <= 100; i++){
        if(i%divisibleBy == 0){
          count++;
        }

      }

      Console.WriteLine("There is {0} numbers between 1 to 100 which are divisible by {1}.", count, divisibleBy);
    }
  }
}

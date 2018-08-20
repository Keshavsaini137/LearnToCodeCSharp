/*5- Write a program and ask the user to enter an
English word. Count the number of vowels (a, e, o,
u, i) in the word. So, if the user enters
"inadequate", the program should display 6 on the
console.
*/

using System.Collections.Generic;
using System;

namespace fifthProgramApp{
  class fifthProgram{
    public static void Main(String[] args){
      Console.WriteLine("Enter a English Word: ");
      String word = Console.ReadLine();

      List<char> vowels = new List<char>(){'a','e','i','o','u'};

      int count = 0;
      foreach(var charArray in word){

        if(vowels.Contains(charArray)){
          count++;
        }
      }
      Console.WriteLine("{0}", count);

    }
  }
}

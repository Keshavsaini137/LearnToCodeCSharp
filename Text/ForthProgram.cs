/*4- Write a program and ask the user to enter a
few words separated by a space. Use the words to
create a variable name with PascalCase. For
example, if the user types: "number of students",
display "NumberOfStudents". Make sure that the
program is not dependent on the input. So, if the
user types "NUMBER OF STUDENTS", the program
should still display "NumberOfStudents".
*/
using System.Collections.Generic;
using System;

namespace ForthProgramApp{
  class ForthProgram{
    static void Main(String[] args){
      Console.WriteLine("Enter a few words separated by a space.");
      var userInput = Console.ReadLine();

      var result = "";
      foreach(var word in userInput.Split(' ')){
        var newWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);

        result = result + newWord;
      }
        Console.WriteLine(result);
    }
  }
}

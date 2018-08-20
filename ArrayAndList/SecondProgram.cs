/*2- Write a program and ask the user to enter
their name. Use an array to reverse the name and
then store the result in a new string. Display
the reversed name on the console.
*/

using System;

namespace SecondProgramApp{
  class SecondProgram{
    public static void Main(String []args){
      Console.WriteLine("Enter Your Name: ");
      var name = Console.ReadLine();

      char[] nameCharacters = new char[name.Length];
      int j = name.Length-1;

      // for(int i = 0;i<name.Length;i++){
      //   nameCharacters[j] = name[i];
      //   j--;
      // }
      int i = 0;

      foreach(var nameCharacter in name){
        nameCharacters[j] = name[i];
        i++;
        j--;
      }

      String ReverseName = new String(nameCharacters);

      Console.WriteLine("{0}", ReverseName);
    }
  }
}

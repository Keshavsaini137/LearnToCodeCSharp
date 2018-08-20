/*1- When you post a message on Facebook,
depending on the number of people who like your
post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

Write a program and continuously ask the user to
enter different names, until the user presses
Enter (without supplying a name). Depending on
the number of names provided, display a message
based on the above pattern.
*/

using System.Collections.Generic;
using System;

namespace FirstProgramApp{

  class NamesClass{
    List<string> names = new List<string>();

    public void Names(){
      while(true){
        Console.WriteLine("Enter a Name: ");
        var name = Console.ReadLine();
        if(name == "Enter"){
          break;
        }
        if(String.IsNullOrWhiteSpace(name)){
        }
        else{
          names.Add(name);
        }

      }

      if(names.Count == 1){
        Console.WriteLine(names.Count);
        Console.WriteLine("{0} Likes Your Post", names[0]);
      }


      if(names.Count == 2){
        Console.WriteLine(names.Count);
        Console.WriteLine("{0} and {1} Likes Your Post", names[0], names[1]);
      }

        if(names.Count > 2){
          Console.WriteLine(names.Count);
          Console.WriteLine("{0}, {1} and {2} others Like your Post.",names[0], names[1], (names.Count - 2));
        }

  }

  class FirstProgram{
    public static void Main(String [] args){
      NamesClass nameClass = new NamesClass();
      nameClass.Names();

      Console.ReadKey();
    }
  }
}
}

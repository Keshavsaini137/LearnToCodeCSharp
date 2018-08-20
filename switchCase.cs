using System;

namespace switchCaseApplication{
  class switchCase{
    public static void Main(string[] args){

      Console.WriteLine("Write the programming Language Name ");
      String l = Console.ReadLine();
      switch (l){
        case "java":
        Console.WriteLine("You are good at it");
        break;

        case "python":
        Console.WriteLine("Your friend told its good for you");
        break;

        case "c#":
        Console.WriteLine("Learning right now");
        break;

        case "javascript":
        Console.WriteLine("Its used in many ways. And i think its easy ");
        break;

        default:
        Console.WriteLine("I am Fresher needs to learn a lot");
        break;
      }
    }
  }
}

using System;

namespace RandomNumPro1App{
/*Program to generate random number
If the user Enter 2 It will generate two random number.
*/

public class UserInputs{
  public int userInput;
}

  class UserRandom{
    public void RandomCal(int input, out int result){
      Random random = new Random();
      //Createing random numbers from 0 to 50
      for(int i = 0;i < input;i++){
        Console.WriteLine(random.Next(0, 50));
      }
      result = 20;
    }

    //Get related ASCII numbers for your Names.
    public void numberForName(){
      Console.WriteLine();
      Console.Write("Enter your Name:  ");
      String name = Console.ReadLine();

      int[] nameChar = new int[name.Length];

      for(int i = 0; i < name.Length;i++){
        nameChar[i] = (int)name[i];
        Console.Write(nameChar[i]);
      }
    }
  }

  class RandomNumPro1{
    public static void Main(String []args){

      UserInputs UInput = new UserInputs();
      Console.WriteLine();
      Console.Write("Enter how many Random numbers you need:  ");
      UInput.userInput = Convert.ToInt32(Console.ReadLine());
      int input = UInput.userInput;

      UserRandom URandomObj = new UserRandom();
      URandomObj.RandomCal(input, out int result);

      URandomObj.numberForName();
    }
  }
}

using System;

class doWhile{
  public static void Main(string [] args){
    Console.WriteLine("Enter 0 to start loop!");
    int a = Convert.ToInt32(Console.ReadLine());

    do{
      Console.WriteLine("Hello!");
    }
    while(a == 0);
  }
}

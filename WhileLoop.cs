using System;

namespace whileLoopApplication{
  class whileLoop{
    public static void Main(string []args){

      Console.WriteLine("Enter 0 to start and 1 to stop");
      int n = Convert.ToInt32(Console.ReadLine());

      while(n >= 0){
        Console.WriteLine("You are good at it");
        n--;
      }
    }
  }
}

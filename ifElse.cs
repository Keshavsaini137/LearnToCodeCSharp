using System;

namespace ifElseApplication{
  class ifElse{
    public static void Main(String[] args){

      Console.WriteLine("Enter any number: ");
      int n = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter any number1: ");
      int n1 = Convert.ToInt32(Console.ReadLine());

      if(n==n1){

        Console.WriteLine("Both are same numbers " + n%n1);
      }
      //else if((n || n1))
      else{
        Console.WriteLine("They are not same numbers" + n%n1);
      }

      if(n%2 == 0){
        Console.WriteLine(n + " is even number");
      }
      else{
        Console.WriteLine(n + " is odd number");
      }

      String a = "my";
      String b = "ym";

      if(a.Equals(b)){
        Console.WriteLine("Both are Same");
      }



    }
  }
}

using System;

namespace UserInputApplication{

  class calculation{



    //addition
    public int addition(int a,int b){
      int sum = a + b;
      return sum;
    }

    public int subtraction(int a,int b){
      int sub = a - b;
      return sub;
    }

    public int Multiplication(int a,int b){
      int mul = a * b;
      return mul;
    }

    public int Division(int a,int b){
      int div = a / b;
      return div;
    }

  }
  class UserInput{
    static void Main(string[] args){
      //addition
      calculation c = new calculation();

      int a,b,sum,sub,Mul,Div;
      Console.WriteLine("Enter First number: ");
      a = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter Second number: ");
      b = Convert.ToInt32(Console.ReadLine());

      sum = c.addition(a,b);
      sub = c.subtraction(a,b);
      Mul = c.Multiplication(a,b);
      Div = c.Division(a,b);


      Console.WriteLine("sum is : " + sum);
      Console.WriteLine("sum is : " + sub);
      Console.WriteLine("sum is : " + Mul);
      Console.WriteLine("sum is : " + Div);

    }
  }
}

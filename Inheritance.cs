using System;

namespace InheritanceApp{
  public class Input{

    private int FirstNumber;
    //int SecondNumber;

    public void SetFirstNumber(int number){
      FirstNumber = number;
    }
    public int GetFirstName(){
      return FirstNumber;
    }
  }

  class Calculate : Input{
    //Palindrome Number
    int r,rev = 0,num;

    public void Palindrome(int firstNumber){

      num = firstNumber;
      while(firstNumber > 0){
        //121
        r = firstNumber % 10;
        rev = (rev*10)+r;
        firstNumber = firstNumber / 10;
      }

      if(num  == rev){
        Console.WriteLine("{0} is Palindrome Number", num);
      }
      else
      {
        Console.WriteLine("{0} is Not Palindrome Number", num);
      }
    }
  }

  class Inheritance{
    public static void Main(String []args){
      //Calculate cal = new Calculate();
      Calculate cal = new Calculate();
      cal.SetFirstNumber(Convert.ToInt32(Console.ReadLine()));
      int fNum = cal.GetFirstName();

      cal.Palindrome(fNum);
    }
  }
}

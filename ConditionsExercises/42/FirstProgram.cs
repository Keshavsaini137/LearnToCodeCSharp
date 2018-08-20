/*1- Write a program and ask the user
 to enter a number. The number should
be between 1 to 10. If the user enters
 a valid number, display "Valid" on the
 console. Otherwise, display "Invalid".*/

 using System;

 namespace FirstProgramApp{
   class Cal{
     public void ValInVal(int userInput, out string validity){
       if(userInput >= 0 && userInput <= 10 ){
         validity = "Valid";
       }
       else{
         validity = "Invalid";
       }
     }
   }

   class FirstProgram{
     public static void Main(String []args){
        string validity;

       Cal c = new Cal();
       Console.Write("Enter a Number From 0 to 10 : ");
       int userInput = Convert.ToInt32(Console.ReadLine());
       c.ValInVal(userInput, out validity);
       Console.WriteLine("The Number you enter is {0}", validity);
     }
   }
 }

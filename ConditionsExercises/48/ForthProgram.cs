/*4- Write a program that picks a random number
 between 1 and 10. Give the user 4 chances to
 guess the number. If the user guesses the
 number, display “You won"; otherwise, display
 “You lost". (To make sure the program is
 behaving correctly, you can display the secret
 number on the console first.)
 */

 using System;

 namespace ForthProgramApp{
   class ForthProgram{
     public static void Main(String []args){
        byte pickedNum;

       Random randomNum = new Random();
       var generatedNum = randomNum.Next(1,10);
       Console.WriteLine("Pick a random number between 1 to 10.You hav 4 Chances.");

       int i;
       for(i = 0; i<4;i++){
          pickedNum = Convert.ToByte(Console.ReadLine());

          if(generatedNum == pickedNum){
             Console.WriteLine("You Won");
             return;//To terminates the Method
          }
          else{
             Console.WriteLine("Not This Number");
          }

       }
       //Console.WriteLine(i);
       if(i == 4){
           Console.WriteLine("You Lost");
       }

     }
   }
 }

using System;

namespace OutputParametersApp{

   class AllFunctions{
      public void factorialM(int no){
         //factorial 5! = 5*4*3*2*1
         for(int i = no;i>1;i--){
            no = no * (i-1);
         }
         Console.WriteLine(no);
      }

      public void palindromeM(int no2, out int outputR){
         //12521
         //Check the reverse number
         int r,s = 0,n = no2;

         while(n>0){
            r = n%10;
            s = s*10 + r;
            n = n/10;
         }
         Console.WriteLine(s);
         outputR = s;

      }
   }

   class OutputParameters{
      public static void Main(string []args){

         AllFunctions f = new AllFunctions();

         // int no;
         // Console.WriteLine("Enter the number to get Factorial");
         // no = Convert.ToInt32(Console.ReadLine());
         //
         // f.factorialM(no);

         int no2, OutputR;
         Console.WriteLine("Enter the number to find if Palindrome or not");
         no2 = Convert.ToInt32(Console.ReadLine());

         //Returning Output in OutputR. 
         f.palindromeM(no2,out OutputR);

         if(OutputR == no2){
            Console.WriteLine("This is Palindrome Number");
         }
         else{
            Console.WriteLine("This is Not Palindrome Number");
         }

      }
   }
}

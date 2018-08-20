using System;

namespace StarApplication{
  class StarForLoop{
    public static void Main(string [] args){

      for(int i = 0; i<5 ;i++){
        for(int j = 5; j>i ;j--){
          Console.Write(" *");
        }
        Console.WriteLine("");
      }

Console.WriteLine("");

      for(int j = 0; j<5 ;j++){
        for(int i = 0; i<=j ;i++){
          Console.Write(" *");
        }
        Console.WriteLine("");
      }

      Console.WriteLine("");

      for(int i = 0; i<5; i++){
        for(int j = 0; j<5; j++){

          if(j==0 || i==0 || j==4 || i==4){
            Console.Write(" * ");
            }
            else{
              Console.Write("   ");
            }

        }
        Console.WriteLine("");
      }


    }
  }
}

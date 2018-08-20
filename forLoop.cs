using System;

// namespace forLoopApplicaation{
  class forLoop{
    public static void Main(string[] args){

      // for(int i = 0; i<=20; i++){
      //   Console.WriteLine("We are in Loop!");
      // }

      ulong c = 1;

      for(ulong i = 1;;i++){

        ulong m = c * i;

        Console.WriteLine(c + " * " + i + " = " + m);
        c++;
      }
    }
  }
//}

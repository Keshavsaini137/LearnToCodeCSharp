using System;

namespace FirstProgramApp{
  class FirstProgram{
    public static void Main(String [] args){

      var names = new String[5];
      var heights = new float[5];

      int i = 0;
      foreach(var name in names){
        names[i] = Console.ReadLine();
        i++;
      }

      foreach(var show in names){
        Console.WriteLine("{0}", show);
      }

      int count = 0;
      int it = 10;

      foreach(var height in heights){
        heights[count] = 2 + it;
        count++;
        it++;
      }
      int j=0;
      foreach(var height in heights){
        Console.WriteLine("{0}", heights[j]);
        j++;
      }
    }
  }
}

using System;

namespace RandomNumProApp{
  class RandomNumPro{
    public static void Main(String []args){

      Random random = new Random();

      char[] buffer = new char[10];
      for(int i = 0; i<9; i++){
        buffer[i] = (char)('a' + random.Next(0, 26));
      }

      String password = new String(buffer);
      Console.WriteLine(password);
    }
  }
}

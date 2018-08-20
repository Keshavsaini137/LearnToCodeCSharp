using System.Collections.Generic;
using System;

namespace ListApp{
  class List{
    public static void Main(String []args){

      List<int> numbers = new List<int>() {1, 2, 3, 4, 5};

      numbers.Add(4);
      numbers.AddRange(new int[4] {6,5,7,8});

      foreach(var number in numbers){
        Console.WriteLine("{0}", number);
      }

      Console.WriteLine();
      Console.WriteLine("Index of : " + numbers.IndexOf(5, 5));

      Console.WriteLine("LastIndex of : " + numbers.LastIndexOf(5, 5));



      numbers.Remove(1);


      for(int i = 0;i<numbers.Count;i++){
        if(numbers[i] == 5){
          numbers.Remove(numbers[i]);
        }

      }

      foreach(var number in numbers){
        Console.WriteLine("{0}", number);
      }


      numbers.Clear();
      Console.WriteLine("Count : " + numbers.Count);

    }
  }
}

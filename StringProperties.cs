using System;

namespace StringPropertiesApp{
  class DiffStringMethods{
    String name = "My name is Keshav";
    String name1 = "Saini";

    public int lengths;

    public void UsingStrings(){
      Console.WriteLine("{0} {1}" ,name, name1);
      //Length
      lengths = name.Length;
      Console.WriteLine(lengths);

      //Join.
      int[] num = new int[3] {23,23,23};
      string a1 = "hello";
      string a2 = "hello2";
      String list = String.Join(",",a1,a2);
      Console.WriteLine(list);

      //Character
      char firstChar = name[0];
      Console.WriteLine(firstChar);

      //Verbatim String
      string text = "hi keshav\n Saini";//Without Verbatim
      string text1 = @"hi Keshav
      Saini"//With Verbatim (Using @)


    }
  }

  class StringProperties{
    public static void Main(String[] args){
      DiffStringMethods sm = new DiffStringMethods();
      sm.UsingStrings();
    }
  }
}

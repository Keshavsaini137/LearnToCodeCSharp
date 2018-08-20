using System;

namespace ArrayApp{
  class tableC{
    public int number;

    public int[] storeTable = new int[10];


    public void TableFun(int number){
      for(int i = 0; i < 10; i++){
        storeTable[i] = number * (i + 1);
      }
    }

    public void ShowTable(int number){
      for(int i = 0; i <10; i++){
        Console.WriteLine("{0} * {1} = {2}", number , (i+1) , storeTable[i]);
      }
    }

    // public void ArrayLengths(){
    //
    //   int[] iArr = new int[7]{ 1, 3, 4, 5, 1, 1, 7 };
    //
    //   Console.WriteLine(sizeOf(iArr));
    // }
  }

  class ArrayC{
    public static void Main(string[] args){
      tableC tableClass = new tableC();

      Console.WriteLine("Enter the Number which table you wanna see");
      tableClass.number = Convert.ToInt32(Console.ReadLine());
      tableClass.TableFun(tableClass.number);

      tableClass.ShowTable(tableClass.number);

      //tableClass.ArrayLengths();
    }
  }
}

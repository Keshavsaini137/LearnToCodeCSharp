using System;

namespace MultiDimensionalArrayApp{

  public class CreateArray{
    public int [,] array1 = new int[3,3] {{2,3,2},{2,4,3},{2,3,6}};

    public int [,] array2 = new int[2,2];

    public void NewArray(){
      Console.WriteLine("Enter Array Values: ");
      for(int i = 0; i<array2.GetLength(0);i++){
        for(int j = 0;j<array2.GetLength(1);j++){
          array2 [i,j] = Convert.ToInt32(Console.ReadLine());
        }
      }
    }

    public void ShowArray(){
      Console.WriteLine("Array First:");
      for(int i=0; i<array1.GetLength(0);i++){
        for(int j = 0;j<array1.GetLength(1);j++)
        Console.WriteLine(array1[i,j]);
      }
      Console.WriteLine("Array Second:");
      for(int i=0; i<array2.GetLength(0);i++){
        for(int j = 0;j<array2.GetLength(1);j++){
          Console.WriteLine(array2[i,j]);
        }
      }
    }
  }

  class MultiDimensionalArray{
    public static void Main(String []args){
      CreateArray createArrayObj = new CreateArray();
      createArrayObj.NewArray();
      createArrayObj.ShowArray();
    }
  }
}

using System;

//Datatypes
namespace DataTypeSizes{
  class calculateSize{
    //int i = sizeOf(int);

    public int integerS(){
      return sizeof(int);
    }

    public int charS(){
      return sizeof(char);
    }

    /*Object is a DataType Which done Type checking at Compile-Time. It can Store any type of variable (Referance Type)
    */
    public object doubleS(){
      object sizeObj = sizeof(double);
      return sizeObj;
    }

    /*Dynaimc is a DataType Which done Type checking at Run-Time. It can Store any type of variable (Referance Type)
    */
    public dynamic byteS(){
      dynamic byteSize = sizeof(byte);
      return byteSize;
    }

    public void Display(){

      Console.WriteLine("Size of Character in the System : " + charS() + " Byte");

      Console.WriteLine("Size of Double in the System : " + doubleS() + " Byte");

      Console.WriteLine("Size of Byte in the System : " + byteS() + " Byte");
    }

  }

  class DatatypeSizes{
    public static void Main(string[] args){
      calculateSize s = new calculateSize();
      int i = s.integerS();
      Console.WriteLine("Size of Integers in this System : " + i + " Byte");

Object Words = "Hello World!";
String Word1 = "This is C#";
Console.WriteLine(Words + " " +  Word1);
      s.Display();
    }
  }
}

using System;

class newClass{
  public String name;

  public void names(){
    Console.WriteLine("Enter Name: ");
    name = Console.ReadLine();
  }
}

class Enc{
  public static void Main(String []args){

    newClass n = new newClass();

    n.names();

    Console.WriteLine("My Name is " + n.name);
  }
}

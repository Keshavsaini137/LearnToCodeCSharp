using System;

namespace RectangleApplication{
  class Rectangle{

    //member variables
    double length;
    double width;

public void Acceptdetails(){
  length = 4.2;
  width = 2.1;
}
    public double GetArea(){
      return length * width;
    }

    public void Display(){
      Console.WriteLine("Length = " + length);
      Console.WriteLine("width = " + width);
      Console.WriteLine("Area = " + GetArea());
    }
  }

  class ExecuteRectangle{
    static void Main(string[] args){

      Rectangle r = new Rectangle();
      r.Acceptdetails();
      r.Display();
      Console.ReadLine();
    }
  }
}

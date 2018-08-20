using System;

namespace AreaApplication{
  class AreaCal{

    //Area Of Circle.(Pie*r*r)
    const float pie = 3.14f;

    public float circleA(){
      Console.WriteLine("Radius of circle is: ");
      float r = Convert.ToSingle(Console.ReadLine());

      return pie*r*r;
    }
    //Area Of Square.(a*a)
    public void squareA(){
      Console.WriteLine("Side of Square is: ");
      int a = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Area of Square is: " + a*a);
    }
    //Area Of Rectangle.(L*B)
    public void rectangleA(){
      Console.WriteLine("Length of Rectangle is: ");
      int l = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Width of Rectangle is: ");
      int w = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Area of Rectangle is: " + l*w);
    }
    //Area Of Triangle.(H*B/2)Hight * Base / 2
    public void TriangleA(){
      Console.WriteLine("Height of Triangle is: ");
      int h = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Base of Triangle is: ");
      int b = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Area of Triangle is: " + h*b/2);
    }
  }

  class Area{
    public static void Main(string[] args){

      AreaCal ac = new AreaCal();

      Console.WriteLine("Area of Circle is: " + ac.circleA());
      ac.squareA();
      ac.rectangleA();
      ac.TriangleA();

    }
  }
}

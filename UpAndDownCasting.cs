using System;

namespace UpAndDownCastingApp{
  public class Shape{
    public int Width {get; set;}
    public int Height {get; set;}
    public int X {get; set;}
    public int Y {get; set;}

    public void Draw(){

    }
  }

  public class Text : Shape{
    public int FontSize {get; set;}
    public string FontName {get; set;}
  }

  class UpAndDownCasting{
    public static void Main(String[] args){
      // Text text = new Text();
      // Shape shape = text;
      //
      // text.Width = 200;
      // shape.Width = 100;
      //
      // Console.WriteLine(text.Width);

      Shape shape = new Text();
      Text text = (Text) shape;
      text.FontSize();
    }
  }
}

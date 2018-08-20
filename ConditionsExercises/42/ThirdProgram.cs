/*3- Write a program and ask the user to enter
the width and height of an image. Then tell
if the image is landscape or portrait.
*/

using System;

namespace ThirdProgramApp{
  class ThirdProgram{
    public static void Main(String []args){
      Console.Write("Enter the Width of Image: ");
      int width = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the Height of Image: ");
      int height = Convert.ToInt32(Console.ReadLine());

      if(height == width){
        Console.WriteLine("The Image is Square");
      }
      else{
        if(height < width){
          Console.WriteLine("The Image is landscape");
        }
        else{
          Console.WriteLine("The Image is potrait");
        }
      }

    }
  }
}

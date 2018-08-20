/*1- Write a program that reads a text file and
displays the number of words.
*/
using System.IO;
using System;

namespace FirstProgram{
  class FirstProgram{
    static void Main(String[] args){
      var path = @"C:\Users\Star\Desktop\C#\FilesAndDir\file.txt";

      String fileData = "";

      if(File.Exists(path)){
      fileData = File.ReadAllText(path);
      }
      var words = fileData.Split(' ');
      Console.WriteLine("{0}", words.Length);

    }
  }
}

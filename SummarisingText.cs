using System.Collections.Generic;
using System;

namespace SummarisingTextApp{
  class SummarisingTextApp{
    public static void Main(String []args){

      String sentence = "Hello My Name is Keshav Saini and I'm new to C# not to Coding";

      String[] words = sentence.Split(' ');


      List<String> summarisedText = new List<String>();
      int TotalLength = 0;

      foreach(var word in words){
        summarisedText.Add(word);
        TotalLength = TotalLength + word.Length + 1;
        if(TotalLength > 30){
          break;
        }
      }
      var summary = String.Join(" ", summarisedText)  + "...";
      Console.WriteLine(summary);

    }
  }
}

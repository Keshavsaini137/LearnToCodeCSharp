using System.IO;
using System;

namespace FileAndFileInfoApp{
  class FileAndFileInfo{
    static void Main(String []args){

      var path = @"c:\something.jpg";

      File.Copy(@"c:\temp\something.jpg", @"c:\something.jpg", true);
      File.Delete(path);
      if(File.Exists(path)){
        //
      }

      var content = File.ReadAllText(path);

      var fileInfo = new FileInfo(path);
      fileInfo.CopyTo("....");
      fileInfo.Delete();
      if(fileInfo.Exists){
        //
      }
    }
  }
}

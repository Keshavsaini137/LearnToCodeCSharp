using System ;

namespace StringExamplesApp{
  class StringExamples{
    static void Main(String[] args){
      var fullName = "Keshav Saini is my name";

      //Trim will Remove White Space
      Console.WriteLine("Trim: '{0}'", fullName.Trim());
      Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
      Console.WriteLine(fullName);

      int index = fullName.IndexOf(' ');
      string firstName = fullName.Substring(0, index);
      String LastName = fullName.Substring(index + 1);
      Console.WriteLine("First Name: " + firstName);
      Console.WriteLine("Last Name: {0}", LastName);

      String[] names = fullName.Split(' ');
      Console.WriteLine("First Name: {0}", names[0]);
      Console.WriteLine("Last Name: {0}", names[1]);


      Console.WriteLine("New Name: " + fullName.Replace("Keshav", "Star"));

      Console.WriteLine("New Name: " + fullName.Replace('K','k'));

      if(String.IsNullOrWhiteSpace(" ")){
        Console.WriteLine("Invalid");
      }

      var str = "25";
      var age = Convert.ToByte(str);
      Console.WriteLine(age);

      float price = 29.95f;
      Console.WriteLine(price.ToString("C0"));

    }
  }
}

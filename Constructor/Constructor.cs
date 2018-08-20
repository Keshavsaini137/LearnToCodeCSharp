using System;

namespace ConstructorApp
{
  class ConstructorProgram
  {
    public static void Main(String[] args)
    {
      Customer customer = new Customer();
      Console.WriteLine(customer.Id);
      Console.WriteLine(customer.Name);
      Console.WriteLine(customer.Id);
    }
  }
}

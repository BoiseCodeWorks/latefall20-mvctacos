using System;
using timsmvctacos.Controllers;

namespace timsmvctacos
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.ForegroundColor = ConsoleColor.Red;
      new TruckController().Run();
    }
  }
}

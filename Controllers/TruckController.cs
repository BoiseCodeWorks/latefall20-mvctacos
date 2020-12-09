using System;
using System.Threading;
using timsmvctacos.Models;
using timsmvctacos.Services;

namespace timsmvctacos.Controllers
{
  public class TruckController
  {
    public TruckController()
    {
      truckService = new TruckService();
    }

    public bool Running { get; set; } = true;

    public TruckService truckService { get; set; }

    public void Run()
    {
      Console.Clear();
      while (Running)
      {
        Utils.PrintLogo();
        GetUserInput();
      }
    }

    private void GetUserInput()
    {
      System.Console.WriteLine("Welcome to Tims Tacos \nWhat would you like to do? Order / Quit / Stock");
      string input = Console.ReadLine().ToLower();
      switch (input)
      {
        case "order":
        case "o":
          OrderTaco();
          break;
        case "quit":
        case "q":
          Running = false;
          break;
        case "stock":
        case "s":
          StockTaco();
          break;
        case "fun":
          FunTest();
          break;
        default:
          System.Console.WriteLine("Invalid Command");
          break;
      }

    }

    private void FunTest()
    {
      System.Console.WriteLine("Loading");
      for (int i = 0; i < 10; i++)
      {
        System.Console.Write(".");
        Thread.Sleep(125);
      }
      Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
    }

    private void StockTaco()
    {
      Console.Clear();
      truckService.ViewTacos(false);
      System.Console.WriteLine("Select a taco to stock");
      string selection = Console.ReadLine();
      Taco selectedTaco = truckService.CheckTacoAvailability(selection);
      if (selectedTaco == null)
      {
        System.Console.WriteLine("Hmm....");
        Thread.Sleep(500);
        System.Console.WriteLine("Invalid Selection");
        Thread.Sleep(2000);
        Console.Clear();
        return;
      }
      //   System.Console.WriteLine(selectedTaco.Protein);
      System.Console.WriteLine("How many " + selectedTaco.Protein + " tacos do you want to stock ?");
      string input = Console.ReadLine();
      System.Console.WriteLine(truckService.StockTacos(input, selectedTaco));

    }

    private void OrderTaco()
    {
      Console.Clear();
      System.Console.WriteLine(truckService.ViewTacos());
      System.Console.WriteLine("Select a taco to order");
      string selection = Console.ReadLine();
      Taco selectedTaco = truckService.CheckTacoAvailability(selection);
      if (selectedTaco == null)
      {
        System.Console.WriteLine("Invalid Selection");
        return;
      }
      System.Console.WriteLine("How many " + selectedTaco.Protein + " tacos do you want ?");
      string input = Console.ReadLine();
      System.Console.WriteLine(truckService.OrderTacos(input, selectedTaco));

    }
  }
}
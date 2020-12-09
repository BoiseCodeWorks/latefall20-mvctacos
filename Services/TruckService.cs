using System;
using System.Collections.Generic;
using timsmvctacos.Models;

namespace timsmvctacos.Services
{
  public class TruckService
  {
    public TruckService()
    {
      TimsTruck = new Truck("Tims Taco Truck", "West Park Str");
      TimsTruck.Tacos.Add(new Taco("Chicken", 50, "Feathers"));
      TimsTruck.Tacos.Add(new Taco("Snake", 500, "Scales"));
      TimsTruck.Tacos.Add(new Taco("Tofu", 10, "Corn"));

    }

    public Truck TimsTruck { get; set; }
    public string ViewTacos()
    {
      string template = "Tacos Currently In Stock : \n";
      List<Taco> tacos = new List<Taco>();
      tacos.AddRange(TimsTruck.Tacos);
      for (int i = 0; i < tacos.Count; i++)
      {
        template += $"{i + 1}. {tacos[i]} \n";
      }
      return template;
    }

    internal string ViewTacos(bool available)
    {
      string template = "Tacos Stock : \n";
      //typically will just use template and return a string
      //am doing writelintes just to show how you can change colors of text
      System.Console.WriteLine("Tacos Stock : \n");
      List<Taco> tacos = new List<Taco>();
      tacos.AddRange(TimsTruck.Tacos);

      for (int i = 0; i < tacos.Count; i++)
      {
        if (tacos[i].InStock == available)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          System.Console.WriteLine($"{i + 1}. {tacos[i]} \n");
          template += $"{i + 1}. {tacos[i]} \n";
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.White;
          System.Console.WriteLine($"{i + 1}. {tacos[i]} \n");
          template += $"{i + 1}. {tacos[i]} \n";

        }
      }
      return template;
    }

    internal Taco CheckTacoAvailability(string selection)
    {
      int tacoIndex;
      bool valid = Int32.TryParse(selection, out tacoIndex);
      if (!valid || tacoIndex > TimsTruck.Tacos.Count)
      {
        return null;
      }
      return TimsTruck.Tacos[tacoIndex - 1];
    }

    internal string StockTacos(string input, Taco selectedTaco)
    {
      int quantity;
      bool valid = Int32.TryParse(input, out quantity);
      if (!valid)
      {
        return "Enter a number please";
      }
      selectedTaco.Quantity += quantity;
      return "You've stocked " + quantity + " " + selectedTaco.Protein + " tacos";
    }

    internal string OrderTacos(string input, Taco selectedTaco)
    {
      int quantity;
      bool valid = Int32.TryParse(input, out quantity);
      if (!valid)
      {
        return "Enter a number please";
      }
      if (selectedTaco.Quantity >= quantity)
      {
        selectedTaco.Quantity -= quantity;
        return $"Thanks for buying {quantity} tacos";
      }
      else
      {
        return $"We do not have {quantity} {selectedTaco.Protein} available currently";
      }
    }


  }
}
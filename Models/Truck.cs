using System.Collections.Generic;

namespace timsmvctacos.Models
{
  public class Truck
  {
    public Truck(string name, string location)
    {
      Name = name;
      Location = location;
    }


    string _name;
    public string Name { get { return _name; } set { _name = value; } }
    //line 14 & 15 is what 17 does in the background
    // public string Name { get; set; }
    public string Location { get; set; }
    public List<Taco> Tacos { get; set; } = new List<Taco>();
  }
}
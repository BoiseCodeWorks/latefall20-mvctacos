namespace timsmvctacos.Models
{
  public class Taco
  {
    public Taco(string protein, int quantity, string shell)
    {
      Protein = protein;
      Quantity = quantity;
      Shell = shell;
    }

    public string Protein { get; set; }
    public int Quantity { get; set; }
    public bool InStock { get { return Quantity > 0; } }
    public string Shell { get; set; }

    public override string ToString()
    {
      return $"{Protein} {Shell}  x  {Quantity}";
    }
  }
}
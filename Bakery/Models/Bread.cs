namespace PierreBakes.Models
{
  public class Bread
  {
    public int CostOfBread {get; set;}
    public int QuantityOfBread {get; set;}

    public Bread(int qtyBread)
    {
      QuantityOfBread = qtyBread;
      CostOfBread = 5;
    }

    public int MultiBread()
    {
      int total = QuantityOfBread * CostOfBread;
      return total;
    }
  }
}
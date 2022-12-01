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
      int total;
      int freeExtraBread = (QuantityOfBread - (QuantityOfBread % 3)) / 3 * CostOfBread;

      if (QuantityOfBread >= 3) 
      {
        total = (QuantityOfBread * CostOfBread) - freeExtraBread;
      }
      else 
      {
        total = QuantityOfBread * CostOfBread;
      }

      return total;
    }
  }
}
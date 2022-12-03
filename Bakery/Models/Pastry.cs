namespace PierreBakes.Models
{
  public class Pastry
  {
    public int CostOfPastry {get; set;}
    public int QuantityOfPastry {get; set;}
  
  public Pastry (int qtyPastry)
  {
    QuantityOfPastry = qtyPastry;
    CostOfPastry = 2;
  }

  public int MultiPastry()
  {
    int total = CostOfPastry * QuantityOfPastry;
    return total;
  }

  }
}
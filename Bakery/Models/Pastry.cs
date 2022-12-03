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
    int total;
    int halfPastryOff = (QuantityOfPastry - (QuantityOfPastry % 3)) / 3;

    if (QuantityOfPastry >= 3)
    {
      total = (QuantityOfPastry * CostOfPastry) - halfPastryOff;
    }
    else
    {
      total = QuantityOfPastry * CostOfPastry;
    }

    return total;
  }

  }
}
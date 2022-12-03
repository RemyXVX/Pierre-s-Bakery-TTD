using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakes.Models;

namespace PierreBakes.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreationOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void Quantity_PastryQuantity_Int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(1, newPastry.QuantityOfPastry);
    }

    [TestMethod]
    public void Cost_PastryCost_Int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(2, newPastry.CostOfPastry);
    }

    [TestMethod]
    public void Sum_CostOfMultiplePastry_Int()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(4, newPastry.MultiPastry());
    }

    [TestMethod]
    public void Half_BuyTwoExtraOne_Int()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(5, newPastry.MultiPastry());
    }

  }
}
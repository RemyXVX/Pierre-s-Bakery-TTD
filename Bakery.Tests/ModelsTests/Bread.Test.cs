using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakes.Models;

namespace PierreBakes.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreationOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Quantity_BreadQuantity_Int()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(1, newBread.QuantityOfBread);
    }

  [TestMethod]
    public void Cost_BreadCost_Int()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(5, newBread.CostOfBread);
    }

    [TestMethod]
    public void Sum_CostOfMultipleBread_Int()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(10, newBread.MultiBread());
    }

    [TestMethod]
    public void Free_BuyTwoExtraOne_Int()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(10, newBread.MultiBread());
    }
  }
}
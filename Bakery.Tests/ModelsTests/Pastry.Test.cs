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
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}
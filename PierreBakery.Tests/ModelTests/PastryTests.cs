using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod] 
    public void GetCost_ReturnCost_int() {
      Assert.AreEqual(2, Pastry.pastryCost(1));
    }
    [TestMethod] 
    public void GetCost2_ReturnCost_int() {
      Assert.AreEqual(10, Pastry.pastryCost(6));
    }
  }

}
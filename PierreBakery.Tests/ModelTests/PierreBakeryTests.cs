using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using PierreBakery.ModelsP;

namespace PierreBakery.Tests
{
  [TestClass]

  public class PierreBakeryTests
  {
    [TestMethod]
    public void GetPrice_ReturnPrice_int() {
      Assert.AreEqual(15, Bread.priceSolver(3));
    }
    
  }

  [TestClass]
  public class PierreBakeryTestsOne
  {
    [TestMethod] 
    public void GetCost_ReturnCost_int() {
      Assert.AreEqual(19, Pastry.costSolver(11));
    }
  }

}
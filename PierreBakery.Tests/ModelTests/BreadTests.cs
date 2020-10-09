using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests
{
  
  [TestMethod] 
  public void GetNumber_ReturnNumber_int() 
    {
      Bread orderBread = new Bread();
      Assert.AreEqual(20, orderBread.BreadCost(4));
    }
  }
}

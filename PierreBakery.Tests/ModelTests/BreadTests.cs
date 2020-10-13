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
      Assert.AreEqual(5, orderBread.BreadCost(1));
    }
  [TestMethod] 
  public void GetNumber2_ReturnNumber_int() 
    {
      Bread orderBread = new Bread();
      Assert.AreEqual(10, orderBread.BreadCost(2));
    }
  [TestMethod] 
  public void GetNumber3_ReturnNumber_int() 
    {
      Bread orderBread = new Bread();
      Assert.AreEqual(20, orderBread.BreadCost(4));
    }
  [TestMethod] 
  public void GetNumber4_ReturnNumber_int() 
    {
      Bread orderBread = new Bread();
      Assert.AreEqual(35, orderBread.BreadCost(7));
    }
  }
}

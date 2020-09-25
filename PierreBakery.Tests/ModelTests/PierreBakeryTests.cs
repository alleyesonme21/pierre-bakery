using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreBakery.Models;
using PierreBakery.ModelsP;
using System;


namespace PierreBakery.Tests
{
  [TestClass]

  public class PierreBakeryTests
  {
    [TestMethod]
    public void GetPrice_ReturnPrice_int() {
      Assert.AreEqual(10, Bread.priceSolver(2));
    }
    
  }

 [TestClass]
  public class PierreBakeryTestsOne
  {
    [TestMethod] 
    public void GetCost_ReturnCost_int() {
      Assert.AreEqual(5, Pastry.costSolver(2));
    }
  }

}
 
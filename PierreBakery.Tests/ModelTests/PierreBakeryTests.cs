using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreBakery.Models;
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
}
 
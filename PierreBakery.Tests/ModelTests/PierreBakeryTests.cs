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
    public void GetLetter_ReturnLetter_int() {
      Assert.AreEqual(3, Bread.priceSolver(1));
    }
    
  }
}
 
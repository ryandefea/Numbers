using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Numbers.Models;
using System;

namespace Numbers.Tests
{
  [TestClass]
  public class NumberTests 
  { 
    [TestMethod]
    public void NumberConstructor_CreatesInstanceOfNumber_true()
    {
      int numberInput = 3;
      Number newNumber = new Number(numberInput);
      Assert.AreEqual(numberInput, newNumber.Content);
    }

    [TestMethod]
    public void NumberToWord_CreatesWord_true()
    {
      int numberInput = 3;
      string changeWord = "three";
      Number newNumber = new Number(numberInput);
      Assert.AreEqual(changeWord, newNumber.Translator(3));
    }
  }
}
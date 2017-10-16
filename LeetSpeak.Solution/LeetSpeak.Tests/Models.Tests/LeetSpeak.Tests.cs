using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak.Models;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class TranslateTest : IDisposable
  {
    public void Dispose()
    {
      Translate.ClearAll();
    }
    [TestMethod]
    public void Convert_ChangeEToThree_String()
    {
      string newWord = "h3";
      Assert.AreEqual(newWord, Translate.Convert("he"));
    }
    [TestMethod]
    public void Convert_ChangeLToOne_String()
    {
      string newWord = "a11";
      Assert.AreEqual(newWord, Translate.Convert("all"));
    }
    [TestMethod]
    public void Convert_ChangeOToZero_String()
    {
      string newWord = "g00d";
      Assert.AreEqual(newWord, Translate.Convert("good"));
    }
    [TestMethod]
    public void Convert_ChangeTToSeven_String()
    {
      string newWord = "7igh7";
      Assert.AreEqual(newWord, Translate.Convert("tight"));
    }
    [TestMethod]
    public void Convert_ChangeSToZ_String()
    {
      string newWord = "say sizzy";
      Assert.AreEqual(newWord, Translate.Convert("say sissy"));
    }
    [TestMethod]
    public void KylePrac_TestLists_List()
    {
      List<int> newNumber = new List<int> {1};
      CollectionAssert.AreEqual(newNumber, Translate.KylePrac(1));
    }
    [TestMethod]
    public void KylePrac_TestTwice_List()
    {
      List<int> newNumber = new List<int> {1};
      CollectionAssert.AreEqual(newNumber, Translate.KylePrac(1));
    }

  }
}

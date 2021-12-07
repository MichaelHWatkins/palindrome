using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class WordPalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_InputIsAPalindrome_True()
    {
      WordPalindrome testPalindrome = new WordPalindrome();
      Assert.AreEqual(true, testPalindrome.IsPalindrome("abba"));
    }
  }
}
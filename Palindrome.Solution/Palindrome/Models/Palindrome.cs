using System.Linq;

namespace Palindrome
{
  public class WordPalindrome
  {
    public bool IsPalindrome(string input)
    {
      
      if(input.SequenceEqual(input.Reverse()))
      {
        return false;
      }
      else{
        return true;
      }
    }
  }
}
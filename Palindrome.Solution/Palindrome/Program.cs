using System;
using Palindrome;

public class Program
{
  public static void Main()
  {
    WordPalindrome newTracker = new WordPalindrome();
    Console.WriteLine("Enter a string to find out if its a Palindrome.");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Enter your input: ");
    string string1 = Console.ReadLine();
    
    Console.WriteLine("--------------------------");
    
    Console.WriteLine("Is it a Palindrome? " + newTracker.IsPalindrome(string1));

  }
}

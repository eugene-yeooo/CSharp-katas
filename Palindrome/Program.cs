using Palindrome;

string[] testInputs = new string[]
{
    "racecar",    
    "level",      
    "hello",      
    "world",      
    "madam",      
    "civic",      
    "noon",       
    "palindrome", 
    "anna",
};

foreach (var word in testInputs)
{
  Console.WriteLine($"{word} → {PalindromeKata.IsPalindrome(word)}");
}


namespace Palindrome
{
  public class PalindromeKata
  {
    public static bool IsPalindrome(string input)
    {
      var reversed = new string(input.Reverse().ToArray());

      return input == reversed;
    }
  }
}
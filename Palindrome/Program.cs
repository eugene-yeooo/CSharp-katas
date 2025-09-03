

namespace Palindrome
{
  public class PalindromeKata
  {
    public bool IsPalindrome(string input)
    {
      var reversed = new string(input.Reverse().ToArray());

      return input == reversed;
    }
  }
}
using System.Net.Http.Headers;
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
    "A man, a plan, a canal: Panama"
};

Console.WriteLine("Hello World!");
Console.WriteLine("This is my Palindrome kata using a Reverse method:");

foreach (var word in testInputs)
{
  Console.WriteLine($"{word} -> {PalindromeKata.ReverseInput(word)}");
}

Console.WriteLine(" ");
Console.WriteLine("This palindrome checker uses a Two Point method:");

foreach (var word in testInputs)
{
  Console.WriteLine($"{word} -> {PalindromeKata.TwoPoint(word)}");
}

Console.WriteLine("");
Console.WriteLine("This method normalizes for spaces and punctuation:");

foreach (var input in testInputs)
{
  Console.WriteLine($"{input} -> {PalindromeKata.Normalize(input)}");
}



namespace Palindrome
{
  public class PalindromeKata
  {
    public static bool ReverseInput(string input)
    {
      var reversed = new string(input.Reverse().ToArray());

      return input == reversed;
    }
    public static bool TwoPoint(string input)
    {
      var left = 0;
      var right = input.Length - 1;

      while (left < right)
      {
        if (input[left] != input[right])
          return false;

        left++;
        right--;
      }

      return true;
    }
    public static bool Normalize(string input)
    {
      var clean = new string(input.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());

      return clean == new string(clean.Reverse().ToArray());
    }
  }
}
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

Console.WriteLine("Hello World!");
Console.WriteLine("This is my Palindrome kata.");

foreach (var word in testInputs)
{
  Console.WriteLine($"{word} = {PalindromeChecker.TwoPoint(word)}");
}


namespace Palindrome
{
  public class PalindromeChecker
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
  }
}
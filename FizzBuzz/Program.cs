// using FizzBuzz;


// Console.WriteLine("Hello, World!");

// Console.WriteLine("This is my FizzBuzz Kata.");

// var fb = new FizzBuzzKata();


// for (int i = 1; i <= 20; i++)
// {
//   Console.WriteLine(fb.Answer(i));
// }

namespace FizzBuzz
{
  public class FizzBuzzKata
  {
    public string Answer(int i)
    {
      if ((i % 3 == 0) && (i % 5 == 0))
        return "fizzbuzz";

      if (i % 5 == 0)
        return "buzz";

      if (i % 3 == 0)
        return "fizz";

      return i.ToString();
    }
  }


  // alternative solution: use traditional Program.Main approach (more structure & flexibility; use for serious app/production code)

  class Program
  {
    static void Main(string[] args)
    {
      var fb = new FizzBuzzKata();
        
          Console.WriteLine("Hello, World!");

          Console.WriteLine("This is my FizzBuzz Kata.");

      for (int i = 1; i <= 20; i++)
      {
        Console.WriteLine(fb.Answer(i));
      }
    }
  }
}

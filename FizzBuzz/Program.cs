using FizzBuzz;


Console.WriteLine("Hello, World!");

Console.WriteLine("This is my FizzBuzz Kata.");

var fb = new FizzBuzzKata();

for (int i = 0; i <= 30; i++)
{
  Console.WriteLine(fb.Answer(i));
}

namespace FizzBuzz
{
  public class FizzBuzzKata
  {
    public string Answer(int i)
    {
      if ((i % 5 == 0) && (i % 3 == 0))
      return "FizzBuzz";

      if (i % 5 ==0)
      return "Buzz";

      if (i % 3 == 0)
      return "Fizz";

      return i.ToString();
    }
  }


  // alternative solution: use traditional Program.Main approach (more structure & flexibility; use for serious app/production code)

  // class Program
  // {
  //   static void Main(string[] args)
  //   {
  //     var fb = new FizzBuzzKata();
        
  //         Console.WriteLine("Hello, World!");

  //         Console.WriteLine("This is my FizzBuzz Kata.");

  //     for (int i = 1; i <= 30; i++)
  //     {
  //       Console.WriteLine(fb.Answer(i));
  //     }
  //   }
  // }
}

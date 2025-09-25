char[,] board = new char[3, 3];

for (int row = 0; row < 3; row++)
{
  for (int col = 0; col < 3; col++)
  {
    board[row, col] = ' ';
  }
}

void PrintBoard(char[,] board)
{
  for (int row = 0; row < 3; row++)
  {
    Console.WriteLine(" {0} | {1} | {2} ", board[row, 0], board[row, 1], board[row, 2]);
    if (row < 2)
    {
      Console.WriteLine("---+---+---");
    }
  }
}

PrintBoard(board);

char currentPlayer = 'X';

int GetInput(string message)
{
  int value;
  while (true)
  {
    Console.Write(message);
    string? input = Console.ReadLine();

    if (int.TryParse(input, out value) && value >= 0 && value <= 2)
    {
      return value;
    }

    Console.WriteLine("Invalid input. Please neter a number between 0 and 2.");
  }
}
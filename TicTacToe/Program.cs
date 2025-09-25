// establish board
char[,] board = new char[3, 3];


// initialise board with spaces
for (int row = 0; row < 3; row++)
{
  for (int col = 0; col < 3; col++)
  {
    board[row, col] = ' ';
  }
}

// function for printing board and call function
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

// establish current player
char currentPlayer = 'X';

// function for asking player for input
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

// main game loop
while (true)
{
  PrintBoard(board);

  Console.WriteLine($"Player {currentPlayer}'s turn!");

  int row = GetInput("Enter row (0-2): ");
  int col = GetInput("Enter column (0-2): ");

  if (board[row, col] == ' ')
  {
    // place the move
    board[row, col] = currentPlayer;

    // switches player
    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X'; 
  }
  else
  {
    Console.WriteLine("That spot is already taken. Try again!");
  }
}

// check win function
bool CheckWin(char[,] board, char player)
{
  // rows
  for (int row = 0; row < 3; row++)
  {
    if (board[row, 0] == player && board[row, 1] == player && board[row, 2] == player)
    {
      return true;
    }
  }

  // columns
  for (int col = 0; col < 3; col++)
  {
    if (board[0, col] == player && board[1, col] == player && board[2, col] == player)
    {
      return true;
    }
  }

  // diagonals
  if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
  {
    return true;
  }

  if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
  {
    return true;
  }

  return false;

}

// check draw function
bool CheckDraw(char[,] board)
{
  foreach (char cell in board)
  {
    if (cell == ' ')
    {
      return false;
    }
  }

  return true;
}
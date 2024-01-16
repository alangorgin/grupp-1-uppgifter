using System.Dynamic;
using System.Net;

public class Grund_16
{
    public static void Start()
    {
        // Grunder uppgift 16
        // Tic Tac Toe
        char player = 'X';
        int slot;
        char[] board = GetFreshBoard();

        while (!HasWinner(board) && !IsBoardFull(board))
        {
            Console.Clear();
            DisplayBoard(board);

            Console.WriteLine($"Player {player}'s turn. Choose your slot (0-8):");

            while (!int.TryParse(Console.ReadLine(), out slot) || slot < 0 || slot > 8 || board[slot] != ' ')
            {
                Console.WriteLine("Invalid slot, please try again:");
            }

            board[slot] = player;
            player = player == 'X' ? 'O' : 'X';
        }

        Console.Clear();
        DisplayBoard(board);

        if (HasWinner(board))
        {
            Console.WriteLine($"Player {player} wins!");
            return;
        }

        Console.WriteLine("It's a draw!");
    }

    private static char[] GetFreshBoard()
    {
        char[] board = new char[9];
        for (int i = 0; i < 9; i++)
        {
            board[i] = ' ';
        }
        return board;
    }

    private static bool HasWinner(char[] board)
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i * 3] != ' ' && board[i * 3] == board[i * 3 + 1] && board[i * 3] == board[i * 3 + 2] || board[i] != ' ' && board[i] == board[i + 3] && board[i] == board[i + 6])
            {
                return true;
            }
        }

        return board[0] != ' ' && board[0] == board[4] && board[0] == board[8] ||
        board[2] != ' ' && board[2] == board[4] && board[2] == board[6];
    }

    private static bool IsBoardFull(char[] board)
    {
        foreach (var slot in board)
        {
            if (slot == ' ')
            {
                return false;
            }
        }

        return true;
    }

    private static void DisplayBoard(char[] board)
    {
        Console.WriteLine("\n Game Board:");
        Console.WriteLine("     |     |      ");

        for (int i = 0; i < 9; i++)
        {
            Console.Write($"  {board[i]}  ");

            if (i == 2 || i == 5 || i == 8)
            {
                Console.WriteLine();
                if (i != 8)
                {
                    Console.WriteLine("-----|-----|-----");
                }
            }
            else
            {
                Console.Write("|");
            }

            if ((i == 2 || i == 5) && i != 8)
            {
                Console.WriteLine("     |     |      ");
            }
        }

        Console.WriteLine("     |     |      \n");
    }
}
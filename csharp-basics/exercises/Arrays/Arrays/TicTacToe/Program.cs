using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = '-';
            }
        }

        private static void DisplayBoard()
        {
            char player = 'X';
            char winer, check;
            int moveRow, moveColum, restart = 1;
            int countX = 0, countO = 0;
            bool gameEnd = false;
            ConsoleKeyInfo input;

            Console.WriteLine("    --+-+--");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
            while (restart == 1)
            {
                countX = 0;
                countO = 0;
                if (countX > countO)
                {
                    player = 'O';
                }
                else if (countX <= countO)
                {
                    player = 'X';
                }

                while (gameEnd != true)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Player: {player}");
                    Console.WriteLine("Enter youre move colum");
                    input = Console.ReadKey();
                    moveColum = int.Parse(input.KeyChar.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Enter youre move row");
                    input = Console.ReadKey();
                    moveRow = int.Parse(input.KeyChar.ToString());
                    Console.WriteLine();

                    if (board[moveColum, moveRow] == 'X' || board[moveColum, moveRow] == 'O')
                    {
                        Console.WriteLine();
                        Console.WriteLine("This place is taken");
                        continue;
                    }
                    else board[moveColum, moveRow] = player;


                    Console.WriteLine("    --+-+--");
                    Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
                    Console.WriteLine("    --+-+--");
                    Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
                    Console.WriteLine("    --+-+--");
                    Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
                    Console.WriteLine("    --+-+--");

                    countX = 0;
                    countO = 0;
                    foreach (var XO in board)
                    {
                        if (XO == 'X')
                        {
                            countX += 1;
                        }
                        else if (XO == 'O')
                        {
                            countO += 1;
                        }
                    }

                    if (countX > countO)
                    {
                        player = 'O';
                    }
                    else if (countX <= countO)
                    {
                        player = 'X';
                    }

                    winer = getWinner();
                    if (winer == 'O' || winer == 'X')
                    {
                        Console.WriteLine($"winer is {winer}");
                        gameEnd = true;
                    }
                    else if (countO + countX == 9)
                    {
                        if (winer == '-')
                        {
                            Console.WriteLine("Its a Draw");
                            gameEnd = true;
                        }
                    }
                }
                Console.WriteLine("Do you want to play agein y/n");
                input = Console.ReadKey();
                check = input.KeyChar;

                if (check == 'y')
                {
                    restart = 1;
                    gameEnd = false;
                    InitBoard();
                }
                else restart = 0;
            }
            Console.ReadKey();
        }

        private static char getWinner()
        {
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
            {
                if (board[0, 0] == '-')
                {
                    return '-';
                }
                else
                    return board[0, 0];
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                if (board[1, 0] == '-')
                {
                    return '-';
                }
                else
                    return board[1, 0];
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                if (board[2, 0] == '-')
                {
                    return '-';
                }
                else
                    return board[2, 0];
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                if (board[0, 0] == '-')
                {
                    return '-';
                }
                else
                    return board[0, 0];
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                if (board[0, 1] == '-')
                {
                    return '-';
                }
                else
                    return board[0, 1];
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                if (board[0, 2] == '-')
                {
                    return '-';
                }
                else
                    return board[0, 2];
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == '-')
                {
                    return '-';
                }
                else
                    return board[0, 0];
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[0, 2] == '-')
                {
                    return '-';
                }
                else
                    return board[0, 2];
            }
            else
            {
                return '-';
            }
        }
    }
}


using System;

namespace tic
{
    class Program
    {
        static void game()
        {
            char[,] y = new char[3, 3] { {'1','2','3'},
            {'4','5','6' },
            {'7','8','9' }};
            char player = 'X';
            char f;
            bool one = true;
            int a, b, d = 3, e = 0;
            Console.Clear();
            Console.WriteLine("X will start");
            Console.WriteLine();
            for (a = 0; a <= 2; a++)
            {
                for (b = 0; b <= 2; b++)
                {
                    Console.Write($"{ y[a, b]}  |");
                }
                Console.WriteLine();
                if (d >= a)
                {
                    Console.WriteLine("---+---+---");
                }
                else
                {
                    Console.WriteLine();
                }
                d--;
            }
            while (one)
            {
                f = Console.ReadLine()[0];
                Console.Clear();
                if (e == 0 || e % 2 == 0)
                {
                    Console.WriteLine("O is next");
                    Console.WriteLine();
                    player = 'X';

                    for (a = 0; a <= 2; a++)
                    {
                        for (b = 0; b <= 2; b++)
                        {
                            if (f == y[a, b])
                            {
                                y[a, b] = player;

                            }
                            Console.Write($"{ y[a, b]}  |");
                        }

                        Console.WriteLine();
                        if (d >= a)
                        {
                            Console.WriteLine("---+---+---");
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                        d--;
                    }
                    if (y[0, 0] == 'X' && y[0, 1] == 'X' && y[0, 2] == 'X')
                    {
                        Console.WriteLine("X won");
                        one = false;
                    }
                    if (y[1, 0] == 'X' && y[1, 1] == 'X' && y[1, 2] == 'X')
                    {
                        Console.WriteLine("X won");
                        one = false;
                    }
                    if (y[2, 0] == 'X' && y[2, 1] == 'X' && y[2, 2] == 'X')
                    {
                        Console.WriteLine("X won");
                        one = false;
                    }
                    if (y[0, 0] == 'X' && y[1, 0] == 'X' && y[2, 0] == 'X')
                    {
                        Console.WriteLine("X won");
                        one = false;
                    }
                    if (y[0, 1] == 'X' && y[1, 1] == 'X' && y[2, 1] == 'X')
                    {
                        Console.WriteLine("X won");
                        one = false;
                    }
                    if (y[0, 2] == 'X' && y[1, 2] == 'X' && y[2, 2] == 'X')
                    {
                        Console.WriteLine("X won");
                        one = false;
                    }
                    if (y[0, 0] == 'X' && y[1, 1] == 'X' && y[2, 2] == 'X')
                    {
                        Console.WriteLine("X won");
                        one = false;
                    }
                    if (y[2, 0] == 'X' && y[1, 1] == 'X' && y[0, 2] == 'X')
                    {
                        Console.WriteLine("X won");
                        one = false;
                    }
                }
                else
                {
                    Console.WriteLine("X is next");
                    Console.WriteLine();
                    player = 'O';

                    for (a = 0; a <= 2; a++)
                    {
                        for (b = 0; b <= 2; b++)
                        {
                            if (f == y[a, b])
                            {
                                y[a, b] = player;

                            }
                            Console.Write($"{ y[a, b]}  |");
                        }

                        Console.WriteLine();
                        if (d >= a)
                        {
                            Console.WriteLine("---+---+---");
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                        d--;
                    }
                    if (y[0, 0] == '0' && y[0, 1] == 'O' && y[0, 2] == 'O')
                    {
                        Console.WriteLine("O won");
                        one = false;
                    }
                    if (y[1, 0] == 'O' && y[1, 1] == 'O' && y[1, 2] == 'O')
                    {
                        Console.WriteLine("O won");
                        one = false;
                    }
                    if (y[2, 0] == 'O' && y[2, 1] == 'O' && y[2, 2] == 'O')
                    {
                        Console.WriteLine("O won");
                        one = false;
                    }
                    if (y[0, 0] == 'O' && y[1, 0] == 'O' && y[2, 0] == 'O')
                    {
                        Console.WriteLine("O won");
                        one = false;
                    }
                    if (y[0, 1] == 'O' && y[1, 1] == 'O' && y[2, 1] == 'O')
                    {
                        Console.WriteLine("O won");
                        one = false;
                    }
                    if (y[0, 2] == 'O' && y[1, 2] == 'O' && y[2, 2] == 'O')
                    {
                        Console.WriteLine("O won");
                        one = false;
                    }
                    if (y[0, 0] == 'O' && y[1, 1] == 'O' && y[2, 2] == 'O')
                    {
                        Console.WriteLine("O won");
                        one = false;
                    }
                    if (y[2, 0] == 'O' && y[1, 1] == 'O' && y[0, 2] == 'O')
                    {
                        Console.WriteLine("O won");
                        one = false;
                    }
                }
                e++;
            }
        }
        static void menu()
        {
            Console.WriteLine("1.New Game");
            Console.WriteLine("2.About an Author");
            Console.WriteLine("3.Exit");
        }
        static void Main(string[] args)
        {
            bool two = true;
            int c;
            string cont = "y";
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine();
            while (two)
            {
                menu();
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        {
                            game();
                            Console.WriteLine();
                            Console.WriteLine("Do you want to play again?  Yes(y),No(n)");
                            cont = Console.ReadLine();
                            Console.WriteLine();
                            if (cont == "y")
                            {
                                Console.WriteLine();
                                continue;
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("The game was created by Aminu Hassan");
                            Console.WriteLine();
                            Console.WriteLine("Copyright 2021");
                            Console.WriteLine();
                            Console.WriteLine("Do you want to continue?  Yes(Y),No(N)");
                            cont = Console.ReadLine();
                            Console.WriteLine();
                            if (cont == "y")
                            {
                                Console.WriteLine();
                                continue;

                            }
                            else
                            {
                                Environment.Exit(0);
                            }

                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Try again");
                            break;
                        }
                }
            }
        }
    }
}

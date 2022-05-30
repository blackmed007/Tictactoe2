using System;

class tic_tac_toe
{



    static void Main()
    {
        char[] position_array = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
    main_menuback:
        Console.WriteLine("1. New Game");
        Console.WriteLine("2. About Author");
        Console.WriteLine("3. Exit");
        int opt = 0;
        while (opt != 3)
        {
        menuback:
            position_array[0] = ' ';
            position_array[1] = ' ';
            position_array[2] = ' ';
            position_array[3] = ' ';
            position_array[4] = ' ';
            position_array[5] = ' ';
            position_array[6] = ' ';
            position_array[7] = ' ';
            position_array[8] = ' ';
            Console.Write(">");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    {
                        Console.WriteLine("\t|\t|");
                        Console.WriteLine("  - - - + - - - + - - - ");
                        Console.WriteLine("\t|\t|");
                        Console.WriteLine("  - - - + - - - + - - - ");
                        Console.WriteLine("\t|\t|");

                        for (int i = 1; i <= 9; i++)
                        {
                            int index = 0;
                        jump1:
                        jump2:
                            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9)
                            {
                                Console.Write("X's move >");
                                index = Convert.ToInt32(Console.ReadLine());
                                if (index < 0 || index > 9)
                                {
                                    Console.WriteLine("Illgel move! try again.");
                                    goto jump1;
                                }

                                if (index >= 1 && index <= 9)
                                {

                                    if (position_array[index - 1] == ' ')
                                    {
                                        position_array[index - 1] = 'X';

                                        if (position_array[0] == 'X' && position_array[1] == 'X' && position_array[2] == 'X' ||
                                           position_array[3] == 'X' && position_array[4] == 'X' && position_array[5] == 'X' ||
                                           position_array[6] == 'X' && position_array[7] == 'X' && position_array[8] == 'X' ||
                                           position_array[0] == 'X' && position_array[3] == 'X' && position_array[6] == 'X' ||
                                           position_array[1] == 'X' && position_array[4] == 'X' && position_array[7] == 'X' ||
                                           position_array[2] == 'X' && position_array[5] == 'X' && position_array[8] == 'X' ||
                                           position_array[2] == 'X' && position_array[4] == 'X' && position_array[6] == 'X' ||
                                           position_array[0] == 'X' && position_array[4] == 'X' && position_array[8] == 'X')
                                        {
                                            Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[0], position_array[1], position_array[2]);
                                            Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                                            Console.WriteLine("     |     |      ");
                                            Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[3], position_array[4], position_array[5]);
                                            Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                                            Console.WriteLine("     |     |      ");
                                            Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[6], position_array[7], position_array[8]);
                                            Console.WriteLine("     |     |      ");
                                            Console.WriteLine("X won!");
                                        jump:
                                            Console.WriteLine("[Press enter to return to main menu...]");
                                            ConsoleKeyInfo c = Console.ReadKey();
                                            if (c.Key == ConsoleKey.Enter)
                                            {
                                                goto main_menuback;
                                            }
                                            else
                                            {
                                                goto jump;
                                            }

                                        }
                                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[0], position_array[1], position_array[2]);
                                        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                                        Console.WriteLine("     |     |      ");
                                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[3], position_array[4], position_array[5]);
                                        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                                        Console.WriteLine("     |     |      ");
                                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[6], position_array[7], position_array[8]);
                                        Console.WriteLine("     |     |      ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Illgel move! try again.");
                                        goto jump1;
                                    }
                                }
                            }
                            else
                            {
                                Console.Write("O's move >");
                                index = Convert.ToInt32(Console.ReadLine());
                                if (index < 0 || index > 9)
                                {
                                    Console.WriteLine("Illgel move! try again.");
                                    goto jump2;
                                }
                                if (index >= 1 && index <= 9)
                                {

                                    if (position_array[index - 1] == ' ')
                                    {
                                        position_array[index - 1] = 'O';
                                        if (position_array[0] == 'O' && position_array[1] == 'O' && position_array[2] == 'O' ||
                                           position_array[3] == 'O' && position_array[4] == 'O' && position_array[5] == 'O' ||
                                           position_array[6] == 'O' && position_array[7] == 'O' && position_array[8] == 'O' ||
                                           position_array[0] == 'O' && position_array[3] == 'O' && position_array[6] == 'O' ||
                                           position_array[1] == 'O' && position_array[4] == 'O' && position_array[7] == 'O' ||
                                           position_array[2] == 'O' && position_array[5] == 'O' && position_array[8] == 'O' ||
                                           position_array[2] == 'O' && position_array[4] == 'O' && position_array[6] == 'O' ||
                                           position_array[0] == 'O' && position_array[4] == 'O' && position_array[8] == 'O')
                                        {
                                            Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[0], position_array[1], position_array[2]);
                                            Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                                            Console.WriteLine("     |     |      ");
                                            Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[3], position_array[4], position_array[5]);
                                            Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                                            Console.WriteLine("     |     |      ");
                                            Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[6], position_array[7], position_array[8]);
                                            Console.WriteLine("     |     |      ");
                                            Console.WriteLine("O won!");
                                        jump0:
                                            Console.WriteLine("[Press enter to return to main menu...]");
                                            ConsoleKeyInfo c = Console.ReadKey();
                                            if (c.Key == ConsoleKey.Enter)
                                            {
                                                goto main_menuback;
                                            }
                                            else
                                            {
                                                goto jump0;
                                            }

                                        }
                                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[0], position_array[1], position_array[2]);
                                        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                                        Console.WriteLine("     |     |      ");
                                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[3], position_array[4], position_array[5]);
                                        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
                                        Console.WriteLine("     |     |      ");
                                        Console.WriteLine("  {0}  |  {1}  |  {2}", position_array[6], position_array[7], position_array[8]);
                                        Console.WriteLine("     |     |      ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Illgel move! try again.");
                                        goto jump2;
                                    }

                                }
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Abdelhamid , student at wsb poznan , 22 years old ");
                        Console.WriteLine("[Press enter to return to main menu...]");
                        ConsoleKeyInfo cc = Console.ReadKey();
                        if (cc.Key == ConsoleKey.Enter)
                        {
                            goto main_menuback;
                        }
                        break;
                    }
                case 3:
                    {
                        char ch;
                        Console.WriteLine("Are you sure you want to quit? [y/n]");
                        Console.Write(">");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch == 'y')
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            goto main_menuback;
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Invalid Input! Please enter again.");
                    goto menuback;
            }
        }
        Console.WriteLine("Game Over!");
    }
}

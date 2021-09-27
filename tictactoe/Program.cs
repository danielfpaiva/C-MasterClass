using System;

namespace Tictactoe
{
    class Program
    {
        // the playfied
        static char[,] playfield =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };

        static int turns = 0;

        static char[,] playfieldInitial =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };

        static void Main(string[] args)
        {
            int player = 2; // player 1 starts
            int input = 0;
            bool inputCorrect = true;

            do
            {
                

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                } else
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                SetField();

                #region
                // check winning condition

                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playfield[0,0]==playerChar) && (playfield[0,1]== playerChar) && (playfield[0, 2] == playerChar))
                        || ((playfield[1, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))
                        || ((playfield[2, 0] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 1] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 1] == playerChar))
                        || ((playfield[2, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[0, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 0] == playerChar) && (playfield[2, 0] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[1, 2] == playerChar) && (playfield[2, 2] == playerChar)))
                    {
                        if(playerChar == 'X')
                        {
                            Console.WriteLine("Player 1 Won!");
                        } else
                        {
                            Console.WriteLine("Player 2 Won!");
                        }

                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();

                        break;
                    } else if (turns == 10)
                    {
                        Console.WriteLine("DRAW!");
                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                    }

                }

                #endregion

                do
                {
                    Console.Write("\nPlayer {0}, Choose your field: ", player);
                    try 
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    } catch 
                    {
                        Console.WriteLine("Please enter a number!");
                    }
                    
                    if ((input == 1) && (playfield[0,0] == '1'))
                    {
                        inputCorrect = true;
                    } else if ((input == 2) && (playfield[0, 1] == '2'))
                    {
                        inputCorrect = true;
                    } else if ((input == 3) && (playfield[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    } else if ((input == 4) && (playfield[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    } else if ((input == 5) && (playfield[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    } else if ((input == 6) && (playfield[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    } else if ((input == 7) && (playfield[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    } else if ((input == 8) && (playfield[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    } else if ((input == 9) && (playfield[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    } else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);


            } while (true);
        }

        public static void ResetField()
        {

            char[,] playfieldInitial =
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'}
            };

            playfield = playfieldInitial;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[0,0], playfield[0,1], playfield[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[1,0], playfield[1,1], playfield[1,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            turns++;
        }

        public static void EnterXorO (int player, int input)
        {
            char playerSign = ' ';

            if(player == 1)
            {
                playerSign = 'X';
            } else 
            { 
                playerSign = 'O'; 
            }

            switch (input)
            {
                case 1: playfield[0, 0] = playerSign; break;
                case 2: playfield[0, 1] = playerSign; break;
                case 3: playfield[0, 2] = playerSign; break;
                case 4: playfield[1, 0] = playerSign; break;
                case 5: playfield[1, 1] = playerSign; break;
                case 6: playfield[1, 2] = playerSign; break;
                case 7: playfield[2, 0] = playerSign; break;
                case 8: playfield[2, 1] = playerSign; break;
                case 9: playfield[2, 2] = playerSign; break;
            }
        }
    }
}
